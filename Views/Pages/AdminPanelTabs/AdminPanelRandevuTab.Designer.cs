namespace HastaneRandevuSistemi.Views.Pages.AdminPanelTabs
{
    partial class AdminPanelRandevuTab
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
            comboRandevuDoktor = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateRandevu = new DateTimePicker();
            label5 = new Label();
            comboBox2 = new ComboBox();
            dataGridRandevular = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridRandevular).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Randevu Yönetimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Doktor";
            // 
            // comboRandevuDoktor
            // 
            comboRandevuDoktor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboRandevuDoktor.FormattingEnabled = true;
            comboRandevuDoktor.Location = new Point(150, 95);
            comboRandevuDoktor.Name = "comboRandevuDoktor";
            comboRandevuDoktor.Size = new Size(220, 25);
            comboRandevuDoktor.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Hasta";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 25);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 200);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Tarih";
            // 
            // dateRandevu
            // 
            dateRandevu.Location = new Point(150, 195);
            dateRandevu.Name = "dateRandevu";
            dateRandevu.Size = new Size(220, 23);
            dateRandevu.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 250);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 7;
            label5.Text = "Saat";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(150, 245);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(220, 25);
            comboBox2.TabIndex = 8;
            // 
            // dataGridRandevular
            // 
            dataGridRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRandevular.Location = new Point(30, 320);
            dataGridRandevular.Name = "dataGridRandevular";
            dataGridRandevular.Size = new Size(850, 250);
            dataGridRandevular.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(200, 60, 60);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 590);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 10;
            button1.Text = "Randevu İptal";
            button1.UseVisualStyleBackColor = false;
            // 
            // AdminPanelRandevuTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 39, 46);
            Controls.Add(button1);
            Controls.Add(dataGridRandevular);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(dateRandevu);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(comboRandevuDoktor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminPanelRandevuTab";
            Size = new Size(1077, 676);
            ((System.ComponentModel.ISupportInitialize)dataGridRandevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboRandevuDoktor;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateRandevu;
        private Label label5;
        private ComboBox comboBox2;
        private DataGridView dataGridRandevular;
        private Button button1;
    }
}
