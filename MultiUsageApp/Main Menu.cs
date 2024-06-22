using System;
using System.Windows.Forms;

namespace MultiUsageApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            PictureEditor Pic = new PictureEditor();
            Pic.ShowDialog();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            FileConverter Converter = new FileConverter();
            Converter.ShowDialog();
        }

        private void btnMultiDisk_Click(object sender, EventArgs e)
        {
            CSC choise = new CSC();
            choise .ShowDialog();
        }
    }
}
