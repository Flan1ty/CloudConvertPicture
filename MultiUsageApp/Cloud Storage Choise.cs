using System;
using System.Windows.Forms;

namespace MultiUsageApp
{
    public partial class CSC : Form
    {
        public CSC()
        {
            InitializeComponent();
        }

        private void btnYandex_Click(object sender, EventArgs e)
        {
            Cloud_Storage Yandex = new Cloud_Storage();
            Yandex.ShowDialog();
        }

        private void btnOneDrive_Click(object sender, EventArgs e)
        {
            OneDrive oneDrive = new OneDrive();
            oneDrive.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GoogleDrive googleDrive = new GoogleDrive();
            googleDrive.ShowDialog();
        }

        private void btnDropbox_Click(object sender, EventArgs e)
        {
            Dropbox dropbox = new Dropbox();
            dropbox.ShowDialog();
        }
    }
}
