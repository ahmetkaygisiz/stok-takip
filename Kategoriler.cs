using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand komut = new OleDbCommand();

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            // this.kategorilerTableAdapter.Fill(this.depoDataSet.Kategoriler);
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + System.Windows.Forms.Application.StartupPath.ToString() + "\\depo.mdb;");

            kategorileriGetir();
        }

        void kategorileriGetir()
        {
            try
            {
                listBox1.Items.Clear();
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut = new OleDbCommand("Select * From Kategoriler", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku["KategoriAd"].ToString());
                }
                baglanti.Close();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String kategoriKontrol = "SELECT KategoriAd FROM Kategoriler WHERE KategoriAd='"+ textBox1.Text.ToString()+ "'";
                if (!kategoriVarmi(kategoriKontrol))
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        komut = new OleDbCommand("INSERT INTO Kategoriler(KategoriAd) VALUES('" + textBox1.Text.ToString() + "')", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        kategorileriGetir();
                        MessageBox.Show("Kategori eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Kategori Adı Boş Bırakılamaz", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Aynı Kategori Adı Tekrar Eklenemez!", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch
            {

            }         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut = new OleDbCommand("DELETE FROM Kategoriler WHERE KategoriAd='" + listBox1.SelectedItem.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                kategorileriGetir();
                MessageBox.Show("Kategori silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }

        public bool kategoriVarmi(String sorgu)                               // Bunu Database'nde Kayıt Varmı Diye Oluşturduk.
        {
            bool kayit = false; // Bunu İlkte False Yaptık Çünkü Kayıt Yoksa Geriye False Olarak Döncek.
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                OleDbCommand kayitVarmi = new OleDbCommand(sorgu, baglanti);  //Burda Sorguyu gönderdik-Baglanti OleDbConnection Kendine Göre Ayarlarsın
                OleDbDataReader dataReader = kayitVarmi.ExecuteReader();              // Burda Veritabanından Veri Okumak İçin 'OleDbDataReader' Tanımladık. 
                while (dataReader.Read())                                         // Burda 'OleDbDataReader' Okuyoruz Eğer Kayıt Varsa kayit=true; olacaktır.
                    kayit = true;                                    //Yani Kayıt Var Anlamında.
                dataReader.Close();                                           //Sonra dr Kapatıyoruz
                return kayit;                                            //Ve Geriye ya False yada True Dönecektir 'kayit' taki değere Bağlı olara
            }
            catch
            {
                return false;
            }
        }
    }
}
