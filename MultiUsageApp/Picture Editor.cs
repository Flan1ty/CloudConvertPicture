using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MultiUsageApp
{
    public partial class PictureEditor : Form
    {
        private string selectedImagePath = "";
        private string path = @"C:\Users\Student\AppData\Local\Programs\Python\Python312\python.exe";

        public PictureEditor()
        {
            InitializeComponent();
            opnFileDialogFile.Filter = "Image files  (*.jpg, *.jpeg, *.png, *.gif) " + " | *.jpg; *.jpeg; *.png; *.gif";
            cmbBoxFilter.Items.Add("Красный");
            cmbBoxFilter.Items.Add("Зеленый");
            cmbBoxFilter.Items.Add("Синий");
            cmbBoxFilter.Items.Add("Черно-белое");
            cmbBoxFilter.Items.Add("Инверсия");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (opnFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = opnFileDialogFile.FileName;
                pctrBoxPrevie.ImageLocation = selectedImagePath;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Нет фото");
                return;
            }
            String selectedFilter = cmbBoxFilter.SelectedItem.ToString();
            string inputPath = opnFileDialogFile.FileName;
            string outputPath = inputPath.Insert(inputPath.LastIndexOf('.'), "_" + selectedFilter);

            ProcessStartInfo start = new ProcessStartInfo(path)
            {
                Arguments = $"\"C:\\Users\\Student\\Desktop\\ИСП-3.2\\MultiUsageApp\\MultiUsageApp\\" +
                $"filter.py\" \"{selectedFilter}\" \"{inputPath}\" \"{outputPath}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                RedirectStandardError = true
            };
            using (Process process = Process.Start(start))
            {
                string errors = process.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(errors))
                {
                    MessageBox.Show("Error: " + errors);
                    return;
                }
                process.WaitForExit();
                pctrBoxPrevie.ImageLocation = outputPath;
                MessageBox.Show("Filter applied succesfully.");

            }
            pctrBoxPrevie.ImageLocation = outputPath;
        }

        private void change_Click(object sender, EventArgs e)
        {
      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap bmpSave = (Bitmap)pctrBoxPrevie.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "bmp";
            sfd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)

                bmpSave.Save(sfd.FileName, ImageFormat.Bmp);
        }
    }
}
