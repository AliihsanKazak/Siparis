namespace Siparis
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.lbl_ozet = new System.Windows.Forms.Label();
            this.lbl_icecek = new System.Windows.Forms.Label();
            this.lbl_tatli = new System.Windows.Forms.Label();
            this.cmb_yemek = new System.Windows.Forms.ComboBox();
            this.cmb_icecek = new System.Windows.Forms.ComboBox();
            this.cmb_tatli = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yiyecek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tatlı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(110, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sipariş Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(470, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sipariş Özeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(398, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tatlı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(398, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "İçecek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(398, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Yiyecek";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(470, 281);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(193, 20);
            this.lbl_sonuc.TabIndex = 11;
            this.lbl_sonuc.Text = "Siparişiniz Listelenmiştir";
            // 
            // lbl_ozet
            // 
            this.lbl_ozet.AutoSize = true;
            this.lbl_ozet.Location = new System.Drawing.Point(471, 73);
            this.lbl_ozet.Name = "lbl_ozet";
            this.lbl_ozet.Size = new System.Drawing.Size(16, 16);
            this.lbl_ozet.TabIndex = 12;
            this.lbl_ozet.Text = "...";
            // 
            // lbl_icecek
            // 
            this.lbl_icecek.AutoSize = true;
            this.lbl_icecek.Location = new System.Drawing.Point(471, 123);
            this.lbl_icecek.Name = "lbl_icecek";
            this.lbl_icecek.Size = new System.Drawing.Size(16, 16);
            this.lbl_icecek.TabIndex = 13;
            this.lbl_icecek.Text = "...";
            // 
            // lbl_tatli
            // 
            this.lbl_tatli.AutoSize = true;
            this.lbl_tatli.Location = new System.Drawing.Point(471, 176);
            this.lbl_tatli.Name = "lbl_tatli";
            this.lbl_tatli.Size = new System.Drawing.Size(16, 16);
            this.lbl_tatli.TabIndex = 14;
            this.lbl_tatli.Text = "...";
            // 
            // cmb_yemek
            // 
            this.cmb_yemek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_yemek.FormattingEnabled = true;
            this.cmb_yemek.Items.AddRange(new object[] {
            "Cheesburger",
            "Tavuk Fajita",
            "Dallas Steak",
            "New York Steak",
            "Spagetti"});
            this.cmb_yemek.Location = new System.Drawing.Point(110, 57);
            this.cmb_yemek.Name = "cmb_yemek";
            this.cmb_yemek.Size = new System.Drawing.Size(121, 24);
            this.cmb_yemek.TabIndex = 15;
            // 
            // cmb_icecek
            // 
            this.cmb_icecek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_icecek.FormattingEnabled = true;
            this.cmb_icecek.Items.AddRange(new object[] {
            "Coca Cola",
            "Fanta",
            "Sprite",
            "Ayran",
            "Su",
            "İce Tea Şeftali",
            "İce Tea Limon"});
            this.cmb_icecek.Location = new System.Drawing.Point(110, 105);
            this.cmb_icecek.Name = "cmb_icecek";
            this.cmb_icecek.Size = new System.Drawing.Size(121, 24);
            this.cmb_icecek.TabIndex = 16;
            // 
            // cmb_tatli
            // 
            this.cmb_tatli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_tatli.FormattingEnabled = true;
            this.cmb_tatli.Items.AddRange(new object[] {
            "Suffle",
            "Pudding",
            "Soğuk Baklava",
            "Tramisu",
            "Kızarmış Dondurma"});
            this.cmb_tatli.Location = new System.Drawing.Point(110, 146);
            this.cmb_tatli.Name = "cmb_tatli";
            this.cmb_tatli.Size = new System.Drawing.Size(121, 24);
            this.cmb_tatli.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(746, 362);
            this.Controls.Add(this.cmb_tatli);
            this.Controls.Add(this.cmb_icecek);
            this.Controls.Add(this.cmb_yemek);
            this.Controls.Add(this.lbl_tatli);
            this.Controls.Add(this.lbl_icecek);
            this.Controls.Add(this.lbl_ozet);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label lbl_ozet;
        private System.Windows.Forms.Label lbl_icecek;
        private System.Windows.Forms.Label lbl_tatli;
        private System.Windows.Forms.ComboBox cmb_yemek;
        private System.Windows.Forms.ComboBox cmb_icecek;
        private System.Windows.Forms.ComboBox cmb_tatli;
    }
}

