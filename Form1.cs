﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Kitaplik_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Kitaplik.mdb");
        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into Kitaplar(kitapad,yazar,tur,sayfa,durum) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut1.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtKitapYazar.Text);
            komut1.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut1.Parameters.AddWithValue("@p4", txtSayfaSayısı.Text);
            komut1.Parameters.AddWithValue("@p5", durum);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();   
            txtKitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSayfaSayısı.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked= true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Kitaplar where kitapid=@p1 ",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update kitaplar set kitapad=@p1,yazar=@p2,tur=@p3,sayfa=@p4,durum=@p5 where kitapid=@p6",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfaSayısı.Text);
            if (radioButton1.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if(radioButton2.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6",txtKitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where Kitapad=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapbul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar where Kitapad like '%" + txtKitapbul.Text + "%'", baglanti);
           

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
