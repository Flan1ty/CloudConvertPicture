using CefSharp.WinForms;
using CefSharp;
using System;
using System.Windows.Forms;

namespace MultiUsageApp
{
    public partial class GoogleDrive : Form
    {
        public GoogleDrive()
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
                string ClientID = "598285425275-j6a5aja9o78qqv4j63ov1e57u94aetsq.apps.googleusercontent.com";
                string redirectUri = "https://drive.google.com/drive/home";
                string authUrl = $"https://accounts.google.com/o/oauth2/auth?response_type=code&client_id={ClientID}&redirect_uri={redirectUri}&scope=https://www.googleapis.com/auth/drive&access_type=offline";
                chromiumWebBrowser1.Load(authUrl);
            }
            private void ChromeBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
            {
                if (e.Url.StartsWith("https://onedrive.live.com/login/"))
                {
                    string token = ExtractAccessToken(e.Url);
                    if (!string.IsNullOrEmpty(token))
                    {
                        LoadGoogleDrive(token);
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

            private void LoadGoogleDrive(string accessToken)
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
