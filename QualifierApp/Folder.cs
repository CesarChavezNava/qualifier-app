using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QualifierApp
{
    public partial class Folder : Form
    {
        public Folder()
        {
            InitializeComponent();
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = fbd.SelectedPath;
                }
            }
        }

        DataTableCollection dataTableCollection;
        private void BtnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            dataTableCollection = result.Tables;
                        }
                    }
                }
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string dateHomework = dtpHomework.Value.ToString("yyyyMMdd");
            DataTable dtStudents = dataTableCollection[0];

            foreach(DataRow drStudent in dtStudents.Rows)
            {
                string path = string.Format(@"{0}\{1}\{2}", txtFolder.Text, dateHomework, drStudent[0]);
                Directory.CreateDirectory(path);
            }

            MessageBox.Show(string.Format("Las carpetas para las tareas del día {0} han sido creadas.", dtpHomework.Value.ToString("dd/MM/yyyy")));
        }
    }
}
