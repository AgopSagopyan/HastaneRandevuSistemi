namespace HastaneRandevuSistemi.Views.Pages
{
    partial class Verification
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
            panel1 = new Panel();
            code_button = new Button();
            label4 = new Label();
            code_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(code_button);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(code_textBox);
            panel1.Location = new Point(430, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 480);
            panel1.TabIndex = 11;
            // 
            // code_button
            // 
            code_button.BackColor = SystemColors.Highlight;
            code_button.FlatStyle = FlatStyle.Flat;
            code_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            code_button.ForeColor = Color.White;
            code_button.Location = new Point(90, 359);
            code_button.Name = "code_button";
            code_button.Size = new Size(250, 37);
            code_button.TabIndex = 14;
            code_button.Text = "Kaydol";
            code_button.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(90, 267);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "Onay Kodu";
            // 
            // code_textBox
            // 
            code_textBox.Location = new Point(90, 295);
            code_textBox.Name = "code_textBox";
            code_textBox.Size = new Size(250, 23);
            code_textBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 12;
            label1.Text = "Onay kodunu girin...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 88);
            label2.Name = "label2";
            label2.Size = new Size(322, 19);
            label2.TabIndex = 15;
            label2.Text = "Davudittin@gmail.com adli e-postanizi kontrol edin";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(159, 421);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kodu tekrar gönder";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 159);
            label3.Name = "label3";
            label3.Size = new Size(153, 65);
            label3.TabIndex = 17;
            label3.Text = "00:00";
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(panel1);
            Name = "Verification";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button code_button;
        private Label label4;
        private TextBox code_textBox;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}
