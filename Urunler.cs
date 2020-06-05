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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand komut = new OleDbCommand();

        public int durum = 0;
        public int urunID = 0;

        private void Urunler_Load(object sender, EventArgs e)
        {

            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + System.Windows.Forms.Application.StartupPath.ToString() + "\\depo.mdb;");
            if (durum == 1)
            {
                bilgileriGetir();
            }
            kategorileriGetir();
        }

        public void kategorileriGetir()
        {
            try
            {
                comboBox2.Items.Clear();
                baglanti.Open();
                komut = new OleDbCommand("Select * From Kategoriler", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    comboBox2.Items.Add(oku["KategoriAd"].ToString());
                }
                baglanti.Close();
            }
            catch
            {
            }
        }
        void bilgileriGetir()
        {
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("Select * From Urunler Where UrunID=" + urunID, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                kategorileriGetir();
                while (oku.Read())
                {
                    textBox1.Text  = oku["UrunAd"].ToString();
                    comboBox2.Text = oku["KategoriAd"].ToString();
                    textBox3.Text  = oku["UrunAdet"].ToString();
                    textBox4.Text  = oku["UrunBirim"].ToString();
                    textBox2.Text  = oku["UrunKonum"].ToString();
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
                kategorileriGetir();
                if (durum == 1)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        komut = new OleDbCommand("UPDATE Depo SET UrunAd='" + textBox1.Text + "',UrunAdet=" + textBox3.Text + ",UrunBirim='" + textBox4.Text + "',UrunKonum='" + textBox2.Text + "' WHERE UrunId=" + urunID, baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        
                        MessageBox.Show("Değişiklikleriniz kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                        Form1 anaForm = (Form1)Application.OpenForms["Form1"];
                        anaForm.dataGridDoldur("Select * From Depo ORDER BY UrunId");

                    }
                    else
                    {
                        MessageBox.Show("Alanlar Boş Bırakılamaz", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
                    {
                        String urunKontrol = "SELECT UrunAd FROM Depo WHERE UrunAd='" + textBox1.Text.ToString() + "' and UrunBirim='" + textBox4.Text.ToString() + "'";

                        if (!kayitvarmi(urunKontrol))
                        {
                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();

                            komut = new OleDbCommand("INSERT INTO Depo(UrunAd,KategoriAd,UrunAdet,UrunBirim,UrunKonum) VALUES ('" + textBox1.Text +
                                                                                                                        "','" + comboBox2.Text +
                                                                                                                        "','" + textBox3.Text +
                                                                                                                        "','" + textBox4.Text +
                                                                                                                        "','" + textBox2.Text + "')", baglanti);
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Ürününüz kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 anaForm = (Form1)Application.OpenForms["Form1"];
                            anaForm.dataGridDoldur("Select * From Depo ORDER BY UrunId");

                        }
                        else
                        {

                            MessageBox.Show("Aynı isimde ürün ekleyemezsiniz.", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }

                        textBox1.Text = "";
                        comboBox2.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Alanlar Boş Bırakılamaz", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool kayitvarmi(String sorgu)                               // Bunu Database'nde Kayıt Varmı Diye Oluşturduk.
        {
            bool kayit = false; // Bunu İlkte False Yaptık Çünkü Kayıt Yoksa Geriye False Olarak Döncek.
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                OleDbCommand kayitVarmi = new OleDbCommand(sorgu, baglanti);  //Burda Sorguyu gönderdik-Baglanti OleDbConnection Kendine Göre Ayarlarsın
                OleDbDataReader dataReader = kayitVarmi.ExecuteReader();              // Burda Veritabanından Veri Okumak İçin 'OleDbDataReader' Tanımladık. 
                while (dataReader.Read())                                         // Burda 'OleDbDataReader' Okuyoruz Eğer Kayıt Varsa kayit=true; olacaktır.
                    kayit = true;                                                 //Yani Kayıt Var Anlamında.
                dataReader.Close();                                               //Sonra dr Kapatıyoruz
                return kayit;                                                      //Ve Geriye ya False yada True Dönecektir 'kayit' taki değere Bağlı olara
            }
            catch
            {
                return false;
            }
        }
    }
}
