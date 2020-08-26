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
        private int indexCurrentStudent = 0;
        private int maxStudents = 0;
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

                    maxStudents = studentFolders.Count();
                    indexCurrentStudent = 0;

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
                    dgvStudents.AutoResizeColumns();

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
                MessageBox.Show("El alumno no tiene tareas.");
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
                txtNote.Text = "";
            }
            else
            {
                btnClean.Enabled = false;
                txtNote.Text = "";
                indexCurrentImage = maxImages;
                MessageBox.Show("Ya haz calificado toda la tarea.");
            }
        }

        private void BtnHomeworkBefore_Click(object sender, EventArgs e)
        {
            indexCurrentImage--;

            if (indexCurrentImage < 0)
            {
                indexCurrentImage = 0;
            }

            if (maxImages > indexCurrentImage)
            {
                pbImage.Image = new Bitmap(studentImages[indexCurrentImage]);
                txtNote.Text = "";
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FolderForm folderForm = new FolderForm();
            folderForm.Show();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtNote.Text = "";
            pbImage.Image = new Bitmap(studentImages[indexCurrentImage]);
        }

        private void NudPincel_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            brushSize = (int)numericUpDown.Value;
        }

        private void BtnNote_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                using (Font font = new Font("Arial", (int)nudFont.Value))
                {
                    Graphics graphics = Graphics.FromImage(pbImage.Image);
                    SolidBrush brush = new SolidBrush(brushColor);
                    graphics.DrawString(txtNote.Text, font, brush, new Point(10, 10));
                    graphics.Save();

                    pbImage.Image = pbImage.Image;
                }
            }
        }

        private void BtnNextStudent_Click(object sender, EventArgs e)
        {
            indexCurrentStudent++;

            if(indexCurrentStudent < maxStudents)
            {
                cbStudent.SelectedIndex = indexCurrentStudent;
                dgvStudents.Rows[indexCurrentStudent].Selected = true;
            } else
            {
                MessageBox.Show("Ya no hay mas alumnos.");
            }
        }
    }
}
