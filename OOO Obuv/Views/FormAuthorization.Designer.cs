namespace OOO_Obuv
{
    partial class FormAuthorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelNameForm = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.TableLayoutAuthorization = new System.Windows.Forms.TableLayoutPanel();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxCaptcha = new System.Windows.Forms.TextBox();
            this.PictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonLogIn = new System.Windows.Forms.Button();
            this.ButtonGuest = new System.Windows.Forms.Button();
            this.TimerCaptcha = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.TableLayoutAuthorization.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.68841F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.68116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.53317F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonExit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelNameForm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonExit.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.Location = new System.Drawing.Point(410, 2);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(142, 56);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelNameForm
            // 
            this.LabelNameForm.AutoSize = true;
            this.LabelNameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelNameForm.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameForm.Location = new System.Drawing.Point(62, 0);
            this.LabelNameForm.Name = "LabelNameForm";
            this.LabelNameForm.Size = new System.Drawing.Size(342, 60);
            this.LabelNameForm.TabIndex = 1;
            this.LabelNameForm.Text = "Авторизация";
            this.LabelNameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Image = global::OOO_Obuv.Properties.Resources.logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxLogo.MaximumSize = new System.Drawing.Size(55, 55);
            this.PictureBoxLogo.MinimumSize = new System.Drawing.Size(55, 55);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(55, 55);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(244)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 461);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(555, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Пользователи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableLayoutAuthorization
            // 
            this.TableLayoutAuthorization.ColumnCount = 2;
            this.TableLayoutAuthorization.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutAuthorization.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutAuthorization.Controls.Add(this.LabelPassword, 0, 1);
            this.TableLayoutAuthorization.Controls.Add(this.TextBoxPassword, 1, 1);
            this.TableLayoutAuthorization.Controls.Add(this.LabelLogin, 0, 0);
            this.TableLayoutAuthorization.Controls.Add(this.TextBoxLogin, 1, 0);
            this.TableLayoutAuthorization.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.TableLayoutAuthorization.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.TableLayoutAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutAuthorization.Location = new System.Drawing.Point(0, 60);
            this.TableLayoutAuthorization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableLayoutAuthorization.Name = "TableLayoutAuthorization";
            this.TableLayoutAuthorization.RowCount = 3;
            this.TableLayoutAuthorization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutAuthorization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutAuthorization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutAuthorization.Size = new System.Drawing.Size(555, 401);
            this.TableLayoutAuthorization.TabIndex = 2;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPassword.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(3, 133);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(271, 133);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Пароль:";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPassword.Font = new System.Drawing.Font("Candara", 13F);
            this.TextBoxPassword.Location = new System.Drawing.Point(280, 135);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '•';
            this.TextBoxPassword.Size = new System.Drawing.Size(272, 34);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLogin.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(3, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(271, 133);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Логин:";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxLogin.Font = new System.Drawing.Font("Candara", 13F);
            this.TextBoxLogin.Location = new System.Drawing.Point(280, 2);
            this.TextBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(272, 34);
            this.TextBoxLogin.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.TextBoxCaptcha, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.PictureBoxCaptcha, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 268);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.3125F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.6875F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(271, 131);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // TextBoxCaptcha
            // 
            this.TextBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxCaptcha.Font = new System.Drawing.Font("Candara", 13F);
            this.TextBoxCaptcha.Location = new System.Drawing.Point(3, 94);
            this.TextBoxCaptcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxCaptcha.Name = "TextBoxCaptcha";
            this.TextBoxCaptcha.Size = new System.Drawing.Size(265, 34);
            this.TextBoxCaptcha.TabIndex = 4;
            // 
            // PictureBoxCaptcha
            // 
            this.PictureBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxCaptcha.Location = new System.Drawing.Point(3, 2);
            this.PictureBoxCaptcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxCaptcha.Name = "PictureBoxCaptcha";
            this.PictureBoxCaptcha.Size = new System.Drawing.Size(265, 88);
            this.PictureBoxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCaptcha.TabIndex = 0;
            this.PictureBoxCaptcha.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.ButtonLogIn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ButtonGuest, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(280, 268);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(272, 131);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLogIn.Font = new System.Drawing.Font("Candara", 13.8F);
            this.ButtonLogIn.Location = new System.Drawing.Point(3, 67);
            this.ButtonLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(266, 62);
            this.ButtonLogIn.TabIndex = 4;
            this.ButtonLogIn.Text = "Войти";
            this.ButtonLogIn.UseVisualStyleBackColor = true;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // ButtonGuest
            // 
            this.ButtonGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonGuest.Font = new System.Drawing.Font("Candara", 13.8F);
            this.ButtonGuest.Location = new System.Drawing.Point(3, 2);
            this.ButtonGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonGuest.Name = "ButtonGuest";
            this.ButtonGuest.Size = new System.Drawing.Size(266, 61);
            this.ButtonGuest.TabIndex = 3;
            this.ButtonGuest.Text = "Гостевой вход";
            this.ButtonGuest.UseVisualStyleBackColor = true;
            this.ButtonGuest.Click += new System.EventHandler(this.ButtonGuest_Click);
            // 
            // TimerCaptcha
            // 
            this.TimerCaptcha.Interval = 1000;
            this.TimerCaptcha.Tick += new System.EventHandler(this.TimerCaptcha_Tick);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 521);
            this.Controls.Add(this.TableLayoutAuthorization);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(570, 558);
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthorization_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutAuthorization.ResumeLayout(false);
            this.TableLayoutAuthorization.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelNameForm;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutAuthorization;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox TextBoxCaptcha;
        private System.Windows.Forms.PictureBox PictureBoxCaptcha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ButtonLogIn;
        private System.Windows.Forms.Button ButtonGuest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer TimerCaptcha;
    }
}

