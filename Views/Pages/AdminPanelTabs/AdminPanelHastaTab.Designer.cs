namespace HastaneRandevuSistemi.Views.Pages.AdminPanelTabs
{
    partial class AdminPanelHastaTab
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHastaAd = new TextBox();
            label3 = new Label();
            txtHastaSoyad = new TextBox();
            label4 = new Label();
            txtTC = new TextBox();
            label5 = new Label();
            comboHastaCinsiyet = new ComboBox();
            label6 = new Label();
            dateHastaDogum = new DateTimePicker();
            label7 = new Label();
            txtTelefon = new TextBox();
            btnHastaEkle = new Button();
            label8 = new Label();
            comboHastaSil = new ComboBox();
            btnHastaSil = new Button();
            dataGridHastalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridHastalar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 0;
            label1.Text = "Hasta Yönetimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 1;
            label2.Text = "Hasta Adı";
            // 
            // txtHastaAd
            // 
            txtHastaAd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtHastaAd.Location = new Point(180, 95);
            txtHastaAd.Name = "txtHastaAd";
            txtHastaAd.Size = new Size(220, 25);
            txtHastaAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 3;
            label3.Text = "Hasta Soyadı";
            // 
            // txtHastaSoyad
            // 
            txtHastaSoyad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtHastaSoyad.Location = new Point(180, 145);
            txtHastaSoyad.Name = "txtHastaSoyad";
            txtHastaSoyad.Size = new Size(220, 25);
            txtHastaSoyad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 200);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 5;
            label4.Text = "Tc Kimlik No";
            // 
            // txtTC
            // 
            txtTC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTC.Location = new Point(180, 195);
            txtTC.MaxLength = 11;
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(220, 25);
            txtTC.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 250);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 7;
            label5.Text = "Cinsiyet";
            // 
            // comboHastaCinsiyet
            // 
            comboHastaCinsiyet.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboHastaCinsiyet.FormattingEnabled = true;
            comboHastaCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboHastaCinsiyet.Location = new Point(180, 245);
            comboHastaCinsiyet.Name = "comboHastaCinsiyet";
            comboHastaCinsiyet.Size = new Size(220, 25);
            comboHastaCinsiyet.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 300);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 9;
            label6.Text = "Doğum Tarihi";
            // 
            // dateHastaDogum
            // 
            dateHastaDogum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateHastaDogum.Location = new Point(180, 295);
            dateHastaDogum.Name = "dateHastaDogum";
            dateHastaDogum.Size = new Size(220, 25);
            dateHastaDogum.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 350);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 11;
            label7.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTelefon.Location = new Point(180, 345);
            txtTelefon.MaxLength = 11;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(220, 25);
            txtTelefon.TabIndex = 12;
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.BackColor = Color.FromArgb(0, 120, 215);
            btnHastaEkle.FlatAppearance.BorderSize = 0;
            btnHastaEkle.FlatStyle = FlatStyle.Flat;
            btnHastaEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnHastaEkle.ForeColor = Color.White;
            btnHastaEkle.Location = new Point(180, 400);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(150, 40);
            btnHastaEkle.TabIndex = 13;
            btnHastaEkle.Text = "Hasta Ekle";
            btnHastaEkle.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.White;
            label8.Location = new Point(500, 100);
            label8.Name = "label8";
            label8.Size = new Size(65, 17);
            label8.TabIndex = 14;
            label8.Text = "Hasta Seç";
            // 
            // comboHastaSil
            // 
            comboHastaSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboHastaSil.FormattingEnabled = true;
            comboHastaSil.Location = new Point(620, 95);
            comboHastaSil.Name = "comboHastaSil";
            comboHastaSil.Size = new Size(220, 25);
            comboHastaSil.TabIndex = 15;
            // 
            // btnHastaSil
            // 
            btnHastaSil.BackColor = Color.FromArgb(200, 60, 60);
            btnHastaSil.FlatAppearance.BorderSize = 0;
            btnHastaSil.FlatStyle = FlatStyle.Flat;
            btnHastaSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnHastaSil.ForeColor = Color.White;
            btnHastaSil.Location = new Point(620, 145);
            btnHastaSil.Name = "btnHastaSil";
            btnHastaSil.Size = new Size(150, 40);
            btnHastaSil.TabIndex = 16;
            btnHastaSil.Text = "Hasta Sil";
            btnHastaSil.UseVisualStyleBackColor = false;
            // 
            // dataGridHastalar
            // 
            dataGridHastalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHastalar.Location = new Point(30, 470);
            dataGridHastalar.Name = "dataGridHastalar";
            dataGridHastalar.Size = new Size(850, 180);
            dataGridHastalar.TabIndex = 17;
            // 
            // AdminPanelHastaTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(dataGridHastalar);
            Controls.Add(btnHastaSil);
            Controls.Add(comboHastaSil);
            Controls.Add(label8);
            Controls.Add(btnHastaEkle);
            Controls.Add(txtTelefon);
            Controls.Add(label7);
            Controls.Add(dateHastaDogum);
            Controls.Add(label6);
            Controls.Add(comboHastaCinsiyet);
            Controls.Add(label5);
            Controls.Add(txtTC);
            Controls.Add(label4);
            Controls.Add(txtHastaSoyad);
            Controls.Add(label3);
            Controls.Add(txtHastaAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminPanelHastaTab";
            Size = new Size(1077, 676);
            ((System.ComponentModel.ISupportInitialize)dataGridHastalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHastaAd;
        private Label label3;
        private TextBox txtHastaSoyad;
        private Label label4;
        private TextBox txtTC;
        private Label label5;
        private ComboBox comboHastaCinsiyet;
        private Label label6;
        private DateTimePicker dateHastaDogum;
        private Label label7;
        private TextBox txtTelefon;
        private Button btnHastaEkle;
        private Label label8;
        private ComboBox comboHastaSil;
        private Button btnHastaSil;
        private DataGridView dataGridHastalar;
    }
}
