using CefSharp.WinForms;
using CefSharp;
using System;
using System.Windows.Forms;

namespace MultiUsageApp
{
    public partial class Dropbox : Form
    {
        private bool isPageLoading = false;
        public Dropbox()
        {
            InitializeComponent();
            InitializeChromium();
            this.Load += MainForm_Load;
        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            this.Controls.Add(chromiumWebBrowser1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.FrameLoadEnd += ChromeBrowser_FrameLoadEnd;

            StartDropboxAuthentication();
        }

        private void ChromeBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Url.StartsWith("https://www.dropbox.com") && e.Url.Contains("code="))
            {
                string code = ExtractCodeFromUrl(e.Url);

            }
        }

        private void StartDropboxAuthentication()
        {
            string clientId = "mmn6m22bxc4tzdo";
            string redirectUri = "https://www.dropbox.com/home";
            string authUrl = $"https://www.dropbox.com/oauth2/authorize?response_type=code&client_id={clientId}&redirect_uri={redirectUri}";
            chromiumWebBrowser1.Load(authUrl);
        }

        private string ExtractCodeFromUrl(string url)
        {
            var codeIndex = url.IndexOf("code=");
            if (codeIndex != -1)
            {
                var code = url.Substring(codeIndex + "code=".Length);
                return code;
            }
            return string.Empty;
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isPageLoading)
            {
                e.Cancel = true;
            }
            else
            {
                Cef.Shutdown();
            }
        }
    }
}
