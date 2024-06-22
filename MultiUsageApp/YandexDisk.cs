using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace MultiUsageApp
{
    public partial class Cloud_Storage : Form
    {
        public Cloud_Storage()
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
            string ClientID = "309031cc6a724863b40ff74affad1588";
            string redirectUri = "https://disk.yandex.ru/client/disk";
            string authUrl = $"https://oauth.yandex.ru/authorize?response_type=token&client_id={ClientID}&redirect_uri={redirectUri}";
            chromiumWebBrowser1.Load(authUrl);
        }
        private void ChromeBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Url.StartsWith("https://oauth.yandex.ru/verification_code"))
            {
                string token = ExtractAccessToken(e.Url);
                if (!string.IsNullOrEmpty(token))
                {
                    LoadYandexDisk(token);
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

        private void LoadYandexDisk(string accessToken)
        {
            string apiRequest = "https://cloud-api.yandex.net/v1/disk/resources/files?oauth_token=" + accessToken;
            chromiumWebBrowser1.Load(apiRequest);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Cef.Shutdown();
            base.OnFormClosing(e);
        }
    }
    
}
