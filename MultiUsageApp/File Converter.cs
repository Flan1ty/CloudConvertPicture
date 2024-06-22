using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace MultiUsageApp
{
    public partial class FileConverter : Form
    {
        public FileConverter()
        {
            InitializeComponent();

            cmbBoxType.Items.Add("DOCX to PDF");
        }

        private void ComvertDocxToPDF(string docPath, string pdfPath)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(docPath);
            doc.ExportAsFixedFormat(pdfPath, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
            doc.Close();
            app.Quit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            opnFileDialogLoad.InitialDirectory = "c:\\";
            opnFileDialogLoad.Filter = "All files DOCX files (*.docx)|*.docx";
            opnFileDialogLoad.FilterIndex = 1;
            opnFileDialogLoad.RestoreDirectory = true;

            if (opnFileDialogLoad.ShowDialog() == DialogResult.OK)
            {
                txtBoxPath.Text = opnFileDialogLoad.FileName;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string inputPath = txtBoxPath.Text;
            string outputPath = "";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                svFileDialogUpload.InitialDirectory = "c:\\";
                svFileDialogUpload.Filter = "PNG files to PDF files (*.pdf)|*.pdf";
                svFileDialogUpload.FilterIndex = 1;
                svFileDialogUpload.RestoreDirectory = true;

                if (svFileDialogUpload.ShowDialog() == DialogResult.OK)
                {
                    outputPath = svFileDialogUpload.FileName;

                    switch (cmbBoxType.SelectedItem.ToString())
                    {
                        case "DOCX to PDF":
                            ComvertDocxToPDF(inputPath, outputPath);
                            break;
                    }
                    MessageBox.Show("Файл успешно сконвертирован и сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
