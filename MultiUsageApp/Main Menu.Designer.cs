namespace MultiUsageApp
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnMultiDisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(139, 89);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(95, 45);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "Open Picture Editor";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(139, 172);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(95, 45);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Open File Convertation";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnMultiDisk
            // 
            this.btnMultiDisk.Location = new System.Drawing.Point(139, 251);
            this.btnMultiDisk.Name = "btnMultiDisk";
            this.btnMultiDisk.Size = new System.Drawing.Size(95, 45);
            this.btnMultiDisk.TabIndex = 2;
            this.btnMultiDisk.Text = "Open Cloud Storage";
            this.btnMultiDisk.UseVisualStyleBackColor = true;
            this.btnMultiDisk.Click += new System.EventHandler(this.btnMultiDisk_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 413);
            this.Controls.Add(this.btnMultiDisk);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnPicture);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnMultiDisk;
    }
}

