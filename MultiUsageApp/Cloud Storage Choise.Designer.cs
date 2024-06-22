namespace MultiUsageApp
{
    partial class CSC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYandex = new System.Windows.Forms.Button();
            this.btnDropbox = new System.Windows.Forms.Button();
            this.btnOneDrive = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYandex
            // 
            this.btnYandex.Location = new System.Drawing.Point(218, 200);
            this.btnYandex.Name = "btnYandex";
            this.btnYandex.Size = new System.Drawing.Size(81, 36);
            this.btnYandex.TabIndex = 0;
            this.btnYandex.Text = "Yandex Disk";
            this.btnYandex.UseVisualStyleBackColor = true;
            this.btnYandex.Click += new System.EventHandler(this.btnYandex_Click);
            // 
            // btnDropbox
            // 
            this.btnDropbox.Location = new System.Drawing.Point(305, 200);
            this.btnDropbox.Name = "btnDropbox";
            this.btnDropbox.Size = new System.Drawing.Size(81, 36);
            this.btnDropbox.TabIndex = 1;
            this.btnDropbox.Text = "Dropbox";
            this.btnDropbox.UseVisualStyleBackColor = true;
            this.btnDropbox.Click += new System.EventHandler(this.btnDropbox_Click);
            // 
            // btnOneDrive
            // 
            this.btnOneDrive.Location = new System.Drawing.Point(392, 200);
            this.btnOneDrive.Name = "btnOneDrive";
            this.btnOneDrive.Size = new System.Drawing.Size(81, 36);
            this.btnOneDrive.TabIndex = 2;
            this.btnOneDrive.Text = "OneDrive";
            this.btnOneDrive.UseVisualStyleBackColor = true;
            this.btnOneDrive.Click += new System.EventHandler(this.btnOneDrive_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "GoogleDrive";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnOneDrive);
            this.Controls.Add(this.btnDropbox);
            this.Controls.Add(this.btnYandex);
            this.Name = "CSC";
            this.Text = "Cloud Storage Choise";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYandex;
        private System.Windows.Forms.Button btnDropbox;
        private System.Windows.Forms.Button btnOneDrive;
        private System.Windows.Forms.Button button4;
    }
}