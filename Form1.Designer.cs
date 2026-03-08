namespace HastaneRandevuSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            panel1 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(525, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 300);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 37);
            label1.TabIndex = 0;
            label1.Text = "Giriş ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 53);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 71);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 109);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Şifre";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 138);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(43, 195);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 5;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1360, 587);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
    }
}
