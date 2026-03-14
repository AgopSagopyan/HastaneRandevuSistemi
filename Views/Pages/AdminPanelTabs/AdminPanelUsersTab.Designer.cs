namespace HastaneRandevuSistemi.Views.Pages.AdminTabs
{
    partial class AdminPanelUsersTab
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
            dataGridView1 = new DataGridView();
            btnRandevuİptal = new Button();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtDoktor = new TextBox();
            btnHastaEkle = new Button();
            btnDoktorEkle = new Button();
            textBox1 = new TextBox();
            btnDoktorSil = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(471, 367);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(464, 217);
            dataGridView1.TabIndex = 22;
            // 
            // btnRandevuİptal
            // 
            btnRandevuİptal.BackColor = Color.FromArgb(200, 60, 60);
            btnRandevuİptal.FlatAppearance.BorderSize = 0;
            btnRandevuİptal.FlatStyle = FlatStyle.Flat;
            btnRandevuİptal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRandevuİptal.ForeColor = Color.White;
            btnRandevuİptal.Location = new Point(215, 427);
            btnRandevuİptal.Name = "btnRandevuİptal";
            btnRandevuİptal.Size = new Size(150, 40);
            btnRandevuİptal.TabIndex = 23;
            btnRandevuİptal.Text = "Randevu İptal";
            btnRandevuİptal.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(142, 93);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 15;
            label2.Text = "Kullanıcı İşlemleri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(142, 333);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 21;
            label5.Text = "Randevular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 143);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 13;
            label1.Text = "Doktor Adı";
            // 
            // txtDoktor
            // 
            txtDoktor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDoktor.Location = new Point(262, 138);
            txtDoktor.Name = "txtDoktor";
            txtDoktor.Size = new Size(200, 25);
            txtDoktor.TabIndex = 14;
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.BackColor = Color.FromArgb(0, 120, 215);
            btnHastaEkle.FlatAppearance.BorderSize = 0;
            btnHastaEkle.FlatStyle = FlatStyle.Flat;
            btnHastaEkle.ForeColor = Color.White;
            btnHastaEkle.Location = new Point(482, 256);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(120, 35);
            btnHastaEkle.TabIndex = 20;
            btnHastaEkle.Text = "Hasta Ekle";
            btnHastaEkle.UseVisualStyleBackColor = false;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.BackColor = Color.FromArgb(0, 120, 215);
            btnDoktorEkle.FlatAppearance.BorderSize = 0;
            btnDoktorEkle.FlatStyle = FlatStyle.Flat;
            btnDoktorEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDoktorEkle.ForeColor = Color.White;
            btnDoktorEkle.Location = new Point(482, 136);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(120, 35);
            btnDoktorEkle.TabIndex = 16;
            btnDoktorEkle.Text = "Doktor Ekle";
            btnDoktorEkle.UseVisualStyleBackColor = false;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(262, 258);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 25);
            textBox1.TabIndex = 19;
            // 
            // btnDoktorSil
            // 
            btnDoktorSil.BackColor = Color.FromArgb(200, 60, 60);
            btnDoktorSil.FlatAppearance.BorderSize = 0;
            btnDoktorSil.FlatStyle = FlatStyle.Flat;
            btnDoktorSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDoktorSil.ForeColor = Color.White;
            btnDoktorSil.Location = new Point(622, 136);
            btnDoktorSil.Name = "btnDoktorSil";
            btnDoktorSil.Size = new Size(120, 35);
            btnDoktorSil.TabIndex = 17;
            btnDoktorSil.Text = "Doktor Sil";
            btnDoktorSil.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(142, 263);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 18;
            label4.Text = "Hasta Adı";
            // 
            // AdminUsersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(dataGridView1);
            Controls.Add(btnRandevuİptal);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtDoktor);
            Controls.Add(btnHastaEkle);
            Controls.Add(btnDoktorEkle);
            Controls.Add(textBox1);
            Controls.Add(btnDoktorSil);
            Controls.Add(label4);
            Name = "AdminUsersTab";
            Size = new Size(1077, 676);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRandevuİptal;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox txtDoktor;
        private Button btnHastaEkle;
        private Button btnDoktorEkle;
        private TextBox textBox1;
        private Button btnDoktorSil;
        private Label label4;
    }
}
