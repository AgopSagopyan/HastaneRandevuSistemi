namespace HastaneRandevuSistemi.Views.Pages.AdminPanelTabs
{
    partial class DoktorProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorProfil));
            panelBilgi = new Panel();
            lblOrtalamaPuan = new Label();
            btnCikis = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            dataGridRandevular = new DataGridView();
            label4 = new Label();
            panelYorumlar = new Panel();
            panel1 = new Panel();
            lblYildiz = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRandevular).BeginInit();
            panelYorumlar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelBilgi
            // 
            panelBilgi.BackColor = Color.FromArgb(45, 45, 45);
            panelBilgi.Controls.Add(lblOrtalamaPuan);
            panelBilgi.Controls.Add(btnCikis);
            panelBilgi.Controls.Add(label2);
            panelBilgi.Controls.Add(label1);
            panelBilgi.Controls.Add(pictureBox1);
            panelBilgi.Dock = DockStyle.Top;
            panelBilgi.Location = new Point(0, 0);
            panelBilgi.Name = "panelBilgi";
            panelBilgi.Size = new Size(1200, 120);
            panelBilgi.TabIndex = 0;
            // 
            // lblOrtalamaPuan
            // 
            lblOrtalamaPuan.AutoSize = true;
            lblOrtalamaPuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOrtalamaPuan.ForeColor = Color.Gold;
            lblOrtalamaPuan.Location = new Point(120, 85);
            lblOrtalamaPuan.Name = "lblOrtalamaPuan";
            lblOrtalamaPuan.Size = new Size(75, 21);
            lblOrtalamaPuan.TabIndex = 4;
            lblOrtalamaPuan.Text = "⭐ 4.7 / 5";
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(200, 60, 60);
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(1080, 20);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 35);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(120, 60);
            label2.Name = "label2";
            label2.Size = new Size(117, 17);
            label2.TabIndex = 2;
            label2.Text = "Kardiyoloji Uzmanı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 30);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 1;
            label1.Text = "Dr.Davut Efe AYBEY";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(213, 30);
            label3.TabIndex = 3;
            label3.Text = "Bugünki Randevular";
            // 
            // dataGridRandevular
            // 
            dataGridRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRandevular.Location = new Point(30, 190);
            dataGridRandevular.Name = "dataGridRandevular";
            dataGridRandevular.Size = new Size(1100, 200);
            dataGridRandevular.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 420);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 5;
            label4.Text = "Hastaların Yorumları";
            // 
            // panelYorumlar
            // 
            panelYorumlar.AutoScroll = true;
            panelYorumlar.BackColor = Color.FromArgb(45, 45, 45);
            panelYorumlar.Controls.Add(panel2);
            panelYorumlar.Controls.Add(panel1);
            panelYorumlar.Location = new Point(30, 460);
            panelYorumlar.Name = "panelYorumlar";
            panelYorumlar.Size = new Size(1100, 178);
            panelYorumlar.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 55);
            panel1.Controls.Add(lblYildiz);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(20, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 70);
            panel1.TabIndex = 0;
            // 
            // lblYildiz
            // 
            lblYildiz.AutoSize = true;
            lblYildiz.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYildiz.ForeColor = Color.Gold;
            lblYildiz.Location = new Point(900, 10);
            lblYildiz.Name = "lblYildiz";
            lblYildiz.Size = new Size(97, 25);
            lblYildiz.TabIndex = 2;
            lblYildiz.Text = "⭐⭐⭐⭐⭐";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(15, 35);
            label6.Name = "label6";
            label6.Size = new Size(193, 15);
            label6.TabIndex = 1;
            label6.Text = "Doktor çok ilgiliydi teşekkür ederim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 10);
            label5.Name = "label5";
            label5.Size = new Size(101, 17);
            label5.TabIndex = 0;
            label5.Text = "Mehmet Demir";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 55, 55);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(20, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 70);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(900, 10);
            label7.Name = "label7";
            label7.Size = new Size(29, 25);
            label7.TabIndex = 2;
            label7.Text = "⭐";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(15, 35);
            label8.Name = "label8";
            label8.Size = new Size(357, 15);
            label8.TabIndex = 1;
            label8.Text = "Davut doktor çok kotuydu hic benle ilgilenmedi umarim işten atılır";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.White;
            label9.Location = new Point(15, 10);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 0;
            label9.Text = "Emir Hayal";
            label9.Click += label9_Click;
            // 
            // DoktorProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panelYorumlar);
            Controls.Add(label4);
            Controls.Add(dataGridRandevular);
            Controls.Add(label3);
            Controls.Add(panelBilgi);
            Name = "DoktorProfil";
            Size = new Size(1200, 700);
            panelBilgi.ResumeLayout(false);
            panelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRandevular).EndInit();
            panelYorumlar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBilgi;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dataGridRandevular;
        private Label label4;
        private Panel panelYorumlar;
        private Panel panel1;
        private Label label5;
        private Button btnCikis;
        private Label label6;
        private Label lblOrtalamaPuan;
        private Label lblYildiz;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
