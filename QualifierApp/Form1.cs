using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QualifierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                }
            }
        }

        string[] studentFiles;
        int numberFile = 0;
        int maxNumberFiles = 0;
        private void CbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                numberFile = 0;
                maxNumberFiles = 0;

                studentFiles = Directory.GetFiles(cbStudent.SelectedValue.ToString()).Where(x => !x.Contains("calificado")).ToArray();
                maxNumberFiles = studentFiles.Count();

                pbImage.Image = new Bitmap(studentFiles[numberFile]);
                btnClean.Enabled = true;
            } catch(Exception ex)
            {
                MessageBox.Show("El alumno no tiene ninguna tarea.");
            }
            

        }

        bool draw = false;
        Color color = Color.Blue;
        private void PbImage_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                draw = true;
                Graphics graphics = Graphics.FromImage(pbImage.Image);
                Pen pen = new Pen(color, 4);
                graphics.DrawRectangle(pen, e.X, e.Y, 2, 2);
                graphics.Save();

                pbImage.Image = pbImage.Image;
            }
            catch { }
            
        }

        private void PbImage_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        int s = 3;
        private void PbImage_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (draw)
                {
                    Graphics graphics = Graphics.FromImage(pbImage.Image);
                    SolidBrush brush = new SolidBrush(color);
                    graphics.FillRectangle(brush, e.X, e.Y, s, s);
                    graphics.Save();

                    pbImage.Image = pbImage.Image;
                }
            }
            catch { }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using(ColorDialog cd = new ColorDialog())
            {
                if(cd.ShowDialog() == DialogResult.OK)
                {
                    txtColor.BackColor = cd.Color;
                    color = cd.Color;
                }
            }
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            string path = cbStudent.SelectedItem.ToString();
            Image image = pbImage.Image;
            Bitmap bitmap = new Bitmap(image);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Dispose();

            bitmap.Save(path + @"\calificado-" + Path.GetFileName(studentFiles[numberFile]) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bitmap.Dispose();

            numberFile++;
            if(maxNumberFiles > numberFile)
            {
                pbImage.Image = new Bitmap(studentFiles[numberFile]);
            }
            else
            {
                btnClean.Enabled = false;
                MessageBox.Show("Ya haz calificado toda la tarea.");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Folder folderForm = new Folder();
            folderForm.Show();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            pbImage.Image = new Bitmap(studentFiles[numberFile]);
        }
    }
}
