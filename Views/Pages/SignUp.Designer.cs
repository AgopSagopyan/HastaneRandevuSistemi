namespace HastaneRandevuSistemi.Views.Pages
{
    partial class SignUp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username_textBox = new TextBox();
            email_textBox = new TextBox();
            password_textBox = new TextBox();
            signUp_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            code_textBox = new TextBox();
            label4 = new Label();
            code_button = new Button();
            SuspendLayout();
            // 
            // username_textBox
            // 
            username_textBox.Location = new Point(498, 91);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(213, 23);
            username_textBox.TabIndex = 0;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(498, 154);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(213, 23);
            email_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(498, 217);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(213, 23);
            password_textBox.TabIndex = 2;
            // 
            // signUp_button
            // 
            signUp_button.Location = new Point(545, 504);
            signUp_button.Name = "signUp_button";
            signUp_button.Size = new Size(126, 23);
            signUp_button.TabIndex = 3;
            signUp_button.Text = "Kayit Ol";
            signUp_button.UseVisualStyleBackColor = true;
            signUp_button.Click += signUp_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(498, 60);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 127);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "E-Posta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 189);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Şifre";
            // 
            // code_textBox
            // 
            code_textBox.Location = new Point(162, 181);
            code_textBox.Name = "code_textBox";
            code_textBox.Size = new Size(213, 23);
            code_textBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 154);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "Onay Kodu";
            // 
            // code_button
            // 
            code_button.Location = new Point(211, 221);
            code_button.Name = "code_button";
            code_button.Size = new Size(75, 23);
            code_button.TabIndex = 9;
            code_button.Text = "button1";
            code_button.UseVisualStyleBackColor = true;
            code_button.Click += button1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(code_button);
            Controls.Add(label4);
            Controls.Add(code_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signUp_button);
            Controls.Add(password_textBox);
            Controls.Add(email_textBox);
            Controls.Add(username_textBox);
            Name = "SignUp";
            Size = new Size(1280, 720);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_textBox;
        private TextBox email_textBox;
        private TextBox password_textBox;
        private Button signUp_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox code_textBox;
        private Label label4;
        private Button code_button;
    }
}
