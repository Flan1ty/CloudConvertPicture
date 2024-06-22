namespace MultiUsageApp
{
    partial class FileConverter
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
            this.lblPath = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.opnFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
            this.svFileDialogUpload = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 33);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 66);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(96, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type of convertion";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(47, 30);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(371, 20);
            this.txtBoxPath.TabIndex = 2;
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Location = new System.Drawing.Point(114, 63);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(304, 21);
            this.cmbBoxType.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(15, 127);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(174, 127);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(338, 127);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(80, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Save/Upload";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // opnFileDialogLoad
            // 
            this.opnFileDialogLoad.FileName = "openFileDialog1";
            // 
            // FileConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 185);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbBoxType);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPath);
            this.Name = "FileConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.OpenFileDialog opnFileDialogLoad;
        private System.Windows.Forms.SaveFileDialog svFileDialogUpload;
    }
}