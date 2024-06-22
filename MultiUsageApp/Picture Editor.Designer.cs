namespace MultiUsageApp
{
    partial class PictureEditor
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pctrBoxPrevie = new System.Windows.Forms.PictureBox();
            this.cmbBoxFilter = new System.Windows.Forms.ComboBox();
            this.opnFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPrevie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(31, 61);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(96, 47);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(31, 141);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(96, 47);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(31, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 47);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pctrBoxPrevie
            // 
            this.pctrBoxPrevie.Image = global::MultiUsageApp.Properties.Resources.RayanBob;
            this.pctrBoxPrevie.Location = new System.Drawing.Point(258, 108);
            this.pctrBoxPrevie.Name = "pctrBoxPrevie";
            this.pctrBoxPrevie.Size = new System.Drawing.Size(442, 213);
            this.pctrBoxPrevie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxPrevie.TabIndex = 8;
            this.pctrBoxPrevie.TabStop = false;
            // 
            // cmbBoxFilter
            // 
            this.cmbBoxFilter.FormattingEnabled = true;
            this.cmbBoxFilter.Location = new System.Drawing.Point(258, 81);
            this.cmbBoxFilter.Name = "cmbBoxFilter";
            this.cmbBoxFilter.Size = new System.Drawing.Size(442, 21);
            this.cmbBoxFilter.TabIndex = 9;
            // 
            // opnFileDialogFile
            // 
            this.opnFileDialogFile.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 47);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PictureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBoxFilter);
            this.Controls.Add(this.pctrBoxPrevie);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnApply);
            this.Name = "PictureEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Picture editor";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPrevie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pctrBoxPrevie;
        private System.Windows.Forms.ComboBox cmbBoxFilter;
        private System.Windows.Forms.OpenFileDialog opnFileDialogFile;
        private System.Windows.Forms.Button btnSave;
    }
}