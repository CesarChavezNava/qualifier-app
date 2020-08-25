using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QualifierApp
{
    public partial class MyQualifierForm : Form
    {
        private Color brushColor = Color.Blue;
        private int brushSize = 3;
        private int indexCurrentImage = 0;
        private int maxImages = 0;
        private bool draw = false;

        private string[] studentImages;
        private DataTable students;

        public MyQualifierForm()
        {
            InitializeComponent();

            cbStudent.Enabled = false;
            btnClean.Enabled = false;
            btnComplete.Enabled = false;
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = fbd.SelectedPath;

                    string[] studentFolders = Directory.GetDirectories(fbd.SelectedPath);
                    cbStudent.DataSource = studentFolders;

                    students = new DataTable("Students");
                    students.Clear();

                    students.Columns.Add("Nombre", typeof(string));

                    foreach (string studentFolder in studentFolders)
                    {
                        string[] studentSplit = studentFolder.Split(Path.DirectorySeparatorChar);
                        string student = studentSplit[studentSplit.Count() - 1];

                        DataRow drStudent = students.NewRow();
                        drStudent["Nombre"] = student;

                        students.Rows.Add(student);
                    }

                    dgvStudents.DataSource = students;
                    
                    cbStudent.Enabled = true;
                }
            }
        }

        private void CbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                indexCurrentImage = 0;
                maxImages = 0;
                btnClean.Enabled = true;
                btnComplete.Enabled = true;

                studentImages = Directory.GetFiles(cbStudent.SelectedValue.ToString()).Where(x => !x.Contains("calificado")).ToArray();
                maxImages = studentImages.Count();
                pbImage.Image = new Bitmap(studentImages[indexCurrentImage]); 
            } catch
            {
                MessageBox.Show("No hay tareas cargadas en esta carpeta.");
                btnClean.Enabled = false;
                btnComplete.Enabled = false;
            }
        }
        
        private void PbImage_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                draw = true;
                Graphics graphics = Graphics.FromImage(pbImage.Image);
                Pen pen = new Pen(brushColor, 4);
                graphics.DrawRectangle(pen, e.X, e.Y, 2, 2);
                graphics.Save();

                pbImage.Image = pbImage.Image;
            }
            catch
            {
                MessageBox.Show("No ha cargado imagenes en el panel.");
            }
            
        }

        private void PbImage_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        
        private void PbImage_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (draw)
                {
                    Graphics graphics = Graphics.FromImage(pbImage.Image);
                    SolidBrush brush = new SolidBrush(brushColor);
                    graphics.FillRectangle(brush, e.X, e.Y, brushSize, brushSize);
                    graphics.Save();

                    pbImage.Image = pbImage.Image;
                }
            }
            catch
            {
                MessageBox.Show("No ha cargado imagenes en el panel.");
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using(ColorDialog cd = new ColorDialog())
            {
                if(cd.ShowDialog() == DialogResult.OK)
                {
                    btnColor.BackColor = cd.Color;
                    brushColor = cd.Color;
                }
            }
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            string path = cbStudent.SelectedItem.ToString();

            Bitmap bitmap = new Bitmap(pbImage.Image);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Dispose();

            bitmap.Save(path + @"\calificado-" + Path.GetFileName(studentImages[indexCurrentImage]), System.Drawing.Imaging.ImageFormat.Jpeg);
            bitmap.Dispose();

            indexCurrentImage++;
            if(maxImages > indexCurrentImage)
            {
                pbImage.Image = new Bitmap(studentImages[indexCurrentImage]);
            }
            else
            {
                btnClean.Enabled = false;
                MessageBox.Show("Ya haz calificado toda la tarea.");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FolderForm folderForm = new FolderForm();
            folderForm.Show();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            pbImage.Image = new Bitmap(studentImages[indexCurrentImage]);
        }

        private void NudPincel_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            brushSize = (int)numericUpDown.Value;
        }
    }
}
