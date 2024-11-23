namespace DemoExam.WinForm.Forms
{
    partial class AuthForm
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
            captchaBox = new PictureBox();
            LoginButton = new Button();
            TextBoxCaptcha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)captchaBox).BeginInit();
            SuspendLayout();
            // 
            // captchaBox
            // 
            captchaBox.Location = new Point(310, 165);
            captchaBox.Name = "captchaBox";
            captchaBox.Size = new Size(150, 50);
            captchaBox.TabIndex = 0;
            captchaBox.TabStop = false;
            captchaBox.Click += captchaBox_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(310, 358);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(157, 23);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click;
            // 
            // TextBoxCaptcha
            // 
            TextBoxCaptcha.Location = new Point(310, 268);
            TextBoxCaptcha.Name = "TextBoxCaptcha";
            TextBoxCaptcha.Size = new Size(150, 23);
            TextBoxCaptcha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 238);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите CAPTCHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 39);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Введите логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 97);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Введите пароль";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(310, 126);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(150, 23);
            PasswordTextBox.TabIndex = 6;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(310, 71);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(150, 23);
            LoginTextBox.TabIndex = 7;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxCaptcha);
            Controls.Add(LoginButton);
            Controls.Add(captchaBox);
            Name = "AuthForm";
            Text = "AuthForm";
            Load += AuthForm_Load;
            ((System.ComponentModel.ISupportInitialize)captchaBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox captchaBox;
        private Button LoginButton;
        private TextBox TextBoxCaptcha;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
    }
}