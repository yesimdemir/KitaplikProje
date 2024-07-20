namespace Kitaplik_Proje
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayfaSayısı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtKitapid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKitapbul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ad:";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(137, 53);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(244, 34);
            this.txtKitapAd.TabIndex = 2;
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(137, 93);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(244, 34);
            this.txtKitapYazar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar:";
            // 
            // txtSayfaSayısı
            // 
            this.txtSayfaSayısı.Location = new System.Drawing.Point(137, 133);
            this.txtSayfaSayısı.Name = "txtSayfaSayısı";
            this.txtSayfaSayısı.Size = new System.Drawing.Size(244, 34);
            this.txtSayfaSayısı.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayfa:";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.cmbTur.Location = new System.Drawing.Point(137, 173);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(244, 35);
            this.cmbTur.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(120, 214);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 31);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İkinci El";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(289, 214);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 31);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sıfır";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tür:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(26, 214);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(91, 27);
            this.lblDurum.TabIndex = 11;
            this.lblDurum.Text = "Durum:";
            // 
            // txtKitapid
            // 
            this.txtKitapid.Enabled = false;
            this.txtKitapid.Location = new System.Drawing.Point(136, 12);
            this.txtKitapid.Name = "txtKitapid";
            this.txtKitapid.Size = new System.Drawing.Size(244, 34);
            this.txtKitapid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "KitapID:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(440, 18);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(151, 43);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(440, 67);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(151, 43);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(440, 116);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 43);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(440, 165);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 43);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(699, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtKitapbul
            // 
            this.txtKitapbul.Location = new System.Drawing.Point(809, 206);
            this.txtKitapbul.Name = "txtKitapbul";
            this.txtKitapbul.Size = new System.Drawing.Size(151, 34);
            this.txtKitapbul.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 27);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kitap Adı:";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(809, 246);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(74, 43);
            this.btnBul.TabIndex = 21;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(886, 246);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(74, 43);
            this.btnAra.TabIndex = 22;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1056, 592);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtKitapbul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtKitapid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtSayfaSayısı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayfaSayısı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtKitapid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKitapbul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnAra;
    }
}

