namespace SecretPicture
{
    partial class FormSecretPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretPicture));
            this.buttonShow1 = new System.Windows.Forms.Button();
            this.button_Shtab = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShow1
            // 
            this.buttonShow1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow1.Location = new System.Drawing.Point(58, 208);
            this.buttonShow1.Name = "buttonShow1";
            this.buttonShow1.Size = new System.Drawing.Size(162, 81);
            this.buttonShow1.TabIndex = 0;
            this.buttonShow1.Text = "Радиомеханик";
            this.buttonShow1.UseVisualStyleBackColor = true;
            this.buttonShow1.Click += new System.EventHandler(this.buttonShow1_Click);
            // 
            // button_Shtab
            // 
            this.button_Shtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Shtab.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Shtab.Location = new System.Drawing.Point(639, 208);
            this.button_Shtab.Name = "button_Shtab";
            this.button_Shtab.Size = new System.Drawing.Size(162, 81);
            this.button_Shtab.TabIndex = 0;
            this.button_Shtab.Text = "Штаб";
            this.button_Shtab.UseVisualStyleBackColor = true;
            this.button_Shtab.Click += new System.EventHandler(this.button_Shtab_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(648, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 81);
            this.button2.TabIndex = 0;
            this.button2.Text = "Камбуз";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(58, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 81);
            this.button3.TabIndex = 0;
            this.button3.Text = "Штурман";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSecretPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecretPicture.Properties.Resources._1mainscreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Shtab);
            this.Controls.Add(this.buttonShow1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormSecretPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Секретная картинка";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShow1;
        private System.Windows.Forms.Button button_Shtab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

