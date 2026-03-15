namespace HastaneRandevuSistemi.Views.Pages.AdminTabs
{
    partial class AdminPanelDoctorsTab
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
            label1 = new Label();
            label2 = new Label();
            txtDoktorAd = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboCinsiyet = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBrans = new ComboBox();
            btnDoktorEkle = new Button();
            label7 = new Label();
            comboDoktorSil = new ComboBox();
            btnDoktorSil = new Button();
            dataGridDoktorlar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridDoktorlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 0;
            label1.Text = "Doktor Yönetimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 1;
            label2.Text = "Doktor Adı";
            // 
            // txtDoktorAd
            // 
            txtDoktorAd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDoktorAd.Location = new Point(180, 95);
            txtDoktorAd.Name = "txtDoktorAd";
            txtDoktorAd.Size = new Size(220, 25);
            txtDoktorAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 3;
            label3.Text = "Doktor Soyadı";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(180, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 25);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 200);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 5;
            label4.Text = "Cinsiyet";
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboCinsiyet.Location = new Point(180, 195);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(220, 25);
            comboCinsiyet.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 250);
            label5.Name = "label5";
            label5.Size = new Size(86, 17);
            label5.TabIndex = 7;
            label5.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(180, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 300);
            label6.Name = "label6";
            label6.Size = new Size(40, 17);
            label6.TabIndex = 9;
            label6.Text = "Branş";
            // 
            // comboBrans
            // 
            comboBrans.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBrans.FormattingEnabled = true;
            comboBrans.Items.AddRange(new object[] { "Kardiyoloji", "Dahiliye", "Ortopedi", "Göz Hastalıkları" });
            comboBrans.Location = new Point(180, 295);
            comboBrans.Name = "comboBrans";
            comboBrans.Size = new Size(220, 25);
            comboBrans.TabIndex = 10;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.BackColor = Color.FromArgb(0, 120, 215);
            btnDoktorEkle.FlatAppearance.BorderSize = 0;
            btnDoktorEkle.FlatStyle = FlatStyle.Flat;
            btnDoktorEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDoktorEkle.ForeColor = Color.White;
            btnDoktorEkle.Location = new Point(180, 350);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(150, 40);
            btnDoktorEkle.TabIndex = 11;
            btnDoktorEkle.Text = "Doktor Ekle";
            btnDoktorEkle.UseVisualStyleBackColor = false;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(500, 100);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 12;
            label7.Text = "Doktor Seç";
            // 
            // comboDoktorSil
            // 
            comboDoktorSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboDoktorSil.FormattingEnabled = true;
            comboDoktorSil.Location = new Point(620, 95);
            comboDoktorSil.Name = "comboDoktorSil";
            comboDoktorSil.Size = new Size(220, 25);
            comboDoktorSil.TabIndex = 13;
            // 
            // btnDoktorSil
            // 
            btnDoktorSil.BackColor = Color.FromArgb(200, 60, 60);
            btnDoktorSil.FlatAppearance.BorderSize = 0;
            btnDoktorSil.FlatStyle = FlatStyle.Flat;
            btnDoktorSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDoktorSil.ForeColor = Color.White;
            btnDoktorSil.Location = new Point(620, 145);
            btnDoktorSil.Name = "btnDoktorSil";
            btnDoktorSil.Size = new Size(150, 40);
            btnDoktorSil.TabIndex = 14;
            btnDoktorSil.Text = "Doktor Sil";
            btnDoktorSil.UseVisualStyleBackColor = false;
            // 
            // dataGridDoktorlar
            // 
            dataGridDoktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDoktorlar.Location = new Point(30, 430);
            dataGridDoktorlar.Name = "dataGridDoktorlar";
            dataGridDoktorlar.Size = new Size(850, 200);
            dataGridDoktorlar.TabIndex = 15;
            // 
            // AdminPanelDoctorsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(dataGridDoktorlar);
            Controls.Add(btnDoktorSil);
            Controls.Add(comboDoktorSil);
            Controls.Add(label7);
            Controls.Add(btnDoktorEkle);
            Controls.Add(comboBrans);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(comboCinsiyet);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtDoktorAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminPanelDoctorsTab";
            Size = new Size(1077, 676);
            Load += AdminPanelDoctorsTab_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridDoktorlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDoktorAd;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboCinsiyet;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox comboBrans;
        private Button btnDoktorEkle;
        private Label label7;
        private ComboBox comboDoktorSil;
        private Button btnDoktorSil;
        private DataGridView dataGridDoktorlar;
    }
}
