namespace Cataloguer
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AvtPanel = new System.Windows.Forms.Label();
            this.AvtorPanel = new System.Windows.Forms.Panel();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PictureLogin = new System.Windows.Forms.PictureBox();
            this.PicturePassword = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.AvtorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(131)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.AvtPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 149);
            this.panel2.TabIndex = 9;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(404, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 32);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // AvtPanel
            // 
            this.AvtPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvtPanel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvtPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.AvtPanel.Location = new System.Drawing.Point(0, 0);
            this.AvtPanel.Name = "AvtPanel";
            this.AvtPanel.Size = new System.Drawing.Size(434, 149);
            this.AvtPanel.TabIndex = 0;
            this.AvtPanel.Text = "Авторизация";
            this.AvtPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AvtPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvtPanel_MouseDown);
            this.AvtPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvtPanel_MouseMove);
            // 
            // AvtorPanel
            // 
            this.AvtorPanel.Controls.Add(this.EmailField);
            this.AvtorPanel.Controls.Add(this.pictureBox1);
            this.AvtorPanel.Controls.Add(this.AdminLabel);
            this.AvtorPanel.Controls.Add(this.ButtonLogin);
            this.AvtorPanel.Controls.Add(this.PasswordField);
            this.AvtorPanel.Controls.Add(this.LoginField);
            this.AvtorPanel.Controls.Add(this.PictureLogin);
            this.AvtorPanel.Controls.Add(this.PicturePassword);
            this.AvtorPanel.Location = new System.Drawing.Point(0, 152);
            this.AvtorPanel.Name = "AvtorPanel";
            this.AvtorPanel.Size = new System.Drawing.Size(429, 415);
            this.AvtorPanel.TabIndex = 18;
            this.AvtorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvtorPanel_MouseMove);
            this.AvtorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvtorPanel_MouseMove);
            // 
            // EmailField
            // 
            this.EmailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailField.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EmailField.Location = new System.Drawing.Point(82, 29);
            this.EmailField.Multiline = true;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(293, 64);
            this.EmailField.TabIndex = 25;
            this.EmailField.Enter += new System.EventHandler(this.EmailField_Enter);
            this.EmailField.Leave += new System.EventHandler(this.EmailField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminLabel.ForeColor = System.Drawing.Color.White;
            this.AdminLabel.Location = new System.Drawing.Point(67, 368);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(295, 26);
            this.AdminLabel.TabIndex = 23;
            this.AdminLabel.Text = "Войти как администратор";
            this.AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            this.AdminLabel.MouseEnter += new System.EventHandler(this.AdminLabel_MouseEnter);
            this.AdminLabel.MouseLeave += new System.EventHandler(this.AdminLabel_MouseLeave);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(109)))), ((int)(((byte)(112)))));
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(112, 302);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(231, 50);
            this.ButtonLogin.TabIndex = 22;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(82, 197);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(293, 50);
            this.PasswordField.TabIndex = 21;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginField.Location = new System.Drawing.Point(82, 113);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(293, 64);
            this.LoginField.TabIndex = 20;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // PictureLogin
            // 
            this.PictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogin.Image")));
            this.PictureLogin.Location = new System.Drawing.Point(12, 113);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.Size = new System.Drawing.Size(64, 64);
            this.PictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLogin.TabIndex = 19;
            this.PictureLogin.TabStop = false;
            // 
            // PicturePassword
            // 
            this.PicturePassword.Image = ((System.Drawing.Image)(resources.GetObject("PicturePassword.Image")));
            this.PicturePassword.Location = new System.Drawing.Point(12, 197);
            this.PicturePassword.Name = "PicturePassword";
            this.PicturePassword.Size = new System.Drawing.Size(64, 64);
            this.PicturePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePassword.TabIndex = 18;
            this.PicturePassword.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(434, 568);
            this.Controls.Add(this.AvtorPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.AvtorPanel.ResumeLayout(false);
            this.AvtorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AvtPanel;
        private System.Windows.Forms.Panel AvtorPanel;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox PictureLogin;
        private System.Windows.Forms.PictureBox PicturePassword;
    }
}

