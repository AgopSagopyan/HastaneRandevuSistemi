namespace HastaneRandevuSistemi
{
    partial class LoginPage
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
            Label label1;
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            button3 = new Button();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 37);
            label1.TabIndex = 6;
            label1.Text = "Giriş";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(28, 266);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 11;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 173);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 9;
            label3.Text = "Şifre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 207);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 87);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(854, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 354);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(3, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 306);
            panel2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(218, 28);
            label7.Name = "label7";
            label7.Size = new Size(315, 37);
            label7.TabIndex = 7;
            label7.Text = "Hastane Randevu Sistemi";
            // 
            // button3
            // 
            button3.Location = new Point(506, 187);
            button3.Name = "button3";
            button3.Size = new Size(258, 35);
            button3.TabIndex = 6;
            button3.Text = "Doğrula";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(690, 159);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // button2
            // 
            button2.Location = new Point(98, 187);
            button2.Name = "button2";
            button2.Size = new Size(236, 35);
            button2.TabIndex = 4;
            button2.Text = "Gönder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(443, 125);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 3;
            label5.Text = "Kod :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(31, 125);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 2;
            label4.Text = "E posta :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(506, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 23);
            textBox3.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(925, 506);
            button4.Name = "button4";
            button4.Size = new Size(167, 41);
            button4.TabIndex = 16;
            button4.Text = "Kayıt Ol";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginPage";
            Size = new Size(1280, 720);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Button button2;
        private Label label5;
        private Button button3;
        private Label label7;
        private Button button4;
    }
}
