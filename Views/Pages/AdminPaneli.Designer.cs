namespace HastaneRandevuSistemi
{
    partial class AdminPaneli
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            btnRandevuİptal = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnHastaSil = new Button();
            btnHastaEkle = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnDoktorSil = new Button();
            btnDoktorEkle = new Button();
            label2 = new Label();
            txtDoktor = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 676);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Bottom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 626);
            button4.Name = "button4";
            button4.Size = new Size(200, 50);
            button4.TabIndex = 3;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 100);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 2;
            button3.Text = "Randevu Yönetimi";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 50);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 1;
            button2.Text = "Hasta Yönetimi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 0;
            button1.Text = "Doktor Yönetimi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 30);
            panel2.Controls.Add(btnRandevuİptal);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnHastaSil);
            panel2.Controls.Add(btnHastaEkle);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnDoktorSil);
            panel2.Controls.Add(btnDoktorEkle);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtDoktor);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 676);
            panel2.TabIndex = 1;
            // 
            // btnRandevuİptal
            // 
            btnRandevuİptal.BackColor = Color.FromArgb(200, 60, 60);
            btnRandevuİptal.FlatAppearance.BorderSize = 0;
            btnRandevuİptal.FlatStyle = FlatStyle.Flat;
            btnRandevuİptal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRandevuİptal.ForeColor = Color.White;
            btnRandevuİptal.Location = new Point(30, 620);
            btnRandevuİptal.Name = "btnRandevuİptal";
            btnRandevuİptal.Size = new Size(150, 40);
            btnRandevuİptal.TabIndex = 12;
            btnRandevuİptal.Text = "Randevu İptal";
            btnRandevuİptal.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(850, 300);
            dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 260);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 10;
            label5.Text = "Randevular";
            // 
            // btnHastaSil
            // 
            btnHastaSil.BackColor = Color.FromArgb(200, 60, 60);
            btnHastaSil.FlatAppearance.BorderSize = 0;
            btnHastaSil.FlatStyle = FlatStyle.Flat;
            btnHastaSil.ForeColor = Color.White;
            btnHastaSil.Location = new Point(510, 183);
            btnHastaSil.Name = "btnHastaSil";
            btnHastaSil.Size = new Size(120, 35);
            btnHastaSil.TabIndex = 9;
            btnHastaSil.Text = "Hasta Sil";
            btnHastaSil.UseVisualStyleBackColor = false;
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.BackColor = Color.FromArgb(0, 120, 215);
            btnHastaEkle.FlatAppearance.BorderSize = 0;
            btnHastaEkle.FlatStyle = FlatStyle.Flat;
            btnHastaEkle.ForeColor = Color.White;
            btnHastaEkle.Location = new Point(370, 183);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(120, 35);
            btnHastaEkle.TabIndex = 8;
            btnHastaEkle.Text = "Hasta Ekle";
            btnHastaEkle.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(150, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 190);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 6;
            label4.Text = "Hasta Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 140);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 5;
            label3.Text = "Hasta İşlemleri";
            // 
            // btnDoktorSil
            // 
            btnDoktorSil.BackColor = Color.FromArgb(200, 60, 60);
            btnDoktorSil.FlatAppearance.BorderSize = 0;
            btnDoktorSil.FlatStyle = FlatStyle.Flat;
            btnDoktorSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDoktorSil.ForeColor = Color.White;
            btnDoktorSil.Location = new Point(510, 63);
            btnDoktorSil.Name = "btnDoktorSil";
            btnDoktorSil.Size = new Size(120, 35);
            btnDoktorSil.TabIndex = 4;
            btnDoktorSil.Text = "Doktor Sil";
            btnDoktorSil.UseVisualStyleBackColor = false;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.BackColor = Color.FromArgb(0, 120, 215);
            btnDoktorEkle.FlatAppearance.BorderSize = 0;
            btnDoktorEkle.FlatStyle = FlatStyle.Flat;
            btnDoktorEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDoktorEkle.ForeColor = Color.White;
            btnDoktorEkle.Location = new Point(370, 63);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(120, 35);
            btnDoktorEkle.TabIndex = 3;
            btnDoktorEkle.Text = "Doktor Ekle";
            btnDoktorEkle.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 20);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 2;
            label2.Text = "Doktor İşlemleri";
            // 
            // txtDoktor
            // 
            txtDoktor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDoktor.Location = new Point(150, 65);
            txtDoktor.Name = "txtDoktor";
            txtDoktor.Size = new Size(200, 25);
            txtDoktor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "Doktor Adı";
            // 
            // AdminPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminPaneli";
            Size = new Size(1280, 676);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txtDoktor;
        private Button btnDoktorSil;
        private Button btnDoktorEkle;
        private Label label3;
        private Button btnHastaEkle;
        private TextBox textBox1;
        private Label label4;
        private Button btnHastaSil;
        private Button btnRandevuİptal;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
