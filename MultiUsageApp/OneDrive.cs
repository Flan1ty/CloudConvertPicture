using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace MultiUsageApp
{
    public partial class OneDrive : Form
    {
        public OneDrive()
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
            StartAuthentication();
        }
        private void StartAuthentication()
        {
            string ClientID = "7ff5b1a3-5773-4472-8099-e791b9127ec5";
            string redirectUri = "https://onedrive.live.com/";
            string authUrl = $"https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id={ClientID}&scope=files.readwrite%20offline_access&response_type=code&redirect_uri={redirectUri}";
            chromiumWebBrowser1.Load(authUrl);
        }
        private void ChromeBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Url.StartsWith("https://onedrive.live.com/login/"))
            {
                string token = ExtractAccessToken(e.Url);
                if (!string.IsNullOrEmpty(token))
                {
                    LoadOneDrive(token);
                }
            }
        }
        private string ExtractAccessToken(string url)
        {
            var tokenIndex = url.IndexOf("access_token=");
            if (tokenIndex != -1)
            {
                var token = url.Substring(tokenIndex + "access_token=".Length);
                return token.Split('&')[0];
            }
            return string.Empty;
        }

        private void LoadOneDrive(string accessToken)
        {
            string apiRequest = "https://login.microsoftonline.com/v1/disk/resources/files?oauth_token=" + accessToken;
            chromiumWebBrowser1.Load(apiRequest);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Cef.Shutdown();
            base.OnFormClosing(e);
        }
    }
    
}
