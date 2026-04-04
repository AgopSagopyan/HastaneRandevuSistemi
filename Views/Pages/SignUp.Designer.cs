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
            Label label5;
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
            panel1 = new Panel();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // username_textBox
            // 
            username_textBox.Location = new Point(89, 132);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(250, 23);
            username_textBox.TabIndex = 0;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(89, 215);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(250, 23);
            email_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(87, 289);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(250, 23);
            password_textBox.TabIndex = 2;
            // 
            // signUp_button
            // 
            signUp_button.BackColor = SystemColors.Highlight;
            signUp_button.FlatStyle = FlatStyle.Flat;
            signUp_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            signUp_button.ForeColor = Color.White;
            signUp_button.Location = new Point(85, 343);
            signUp_button.Name = "signUp_button";
            signUp_button.Size = new Size(252, 45);
            signUp_button.TabIndex = 3;
            signUp_button.Text = "Onayla";
            signUp_button.UseVisualStyleBackColor = false;
            signUp_button.Click += signUp_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(39, 48, 49);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 103);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 188);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 5;
            label2.Text = "E-Posta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 262);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Şifre";
            // 
            // code_textBox
            // 
            code_textBox.Location = new Point(898, 644);
            code_textBox.Name = "code_textBox";
            code_textBox.Size = new Size(373, 23);
            code_textBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(918, 597);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 8;
            label4.Text = "Onay Kodu";
            // 
            // code_button
            // 
            code_button.FlatStyle = FlatStyle.Flat;
            code_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            code_button.ForeColor = Color.White;
            code_button.Location = new Point(1147, 685);
            code_button.Name = "code_button";
            code_button.Size = new Size(124, 30);
            code_button.TabIndex = 9;
            code_button.Text = "Kaydol";
            code_button.UseVisualStyleBackColor = true;
            code_button.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(password_textBox);
            panel1.Controls.Add(signUp_button);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(email_textBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(username_textBox);
            panel1.Location = new Point(444, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 480);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 45, 45);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 16);
            button1.Name = "button1";
            button1.Size = new Size(124, 30);
            button1.TabIndex = 10;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(160, 38);
            label5.Name = "label5";
            label5.Size = new Size(107, 37);
            label5.TabIndex = 7;
            label5.Text = "Kaydol";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(137, 414);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(150, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Zaten bir hesabınız var mı ?";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(code_button);
            Controls.Add(label4);
            Controls.Add(code_textBox);
            Name = "SignUp";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}
