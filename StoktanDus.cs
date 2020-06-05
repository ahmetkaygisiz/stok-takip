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
    public partial class StoktanDus : Form
    {
        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand komut = new OleDbCommand();

        public int durum = 0;
        public int urunID = 0;

        public StoktanDus()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void StoktanDus_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + System.Windows.Forms.Application.StartupPath.ToString() + "\\depo.mdb;");
            
            if(durum == 1)
            {
                doldur();
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        void doldur()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut = new OleDbCommand("Select * From Depo Where UrunID=" + urunID, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    tbUrunAd.Text = oku["UrunAd"].ToString();
                    tbUrunAdet.Text = oku["UrunAdet"].ToString();
                }
                baglanti.Close();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDegisiklikKaydet_Click(object sender, EventArgs e)
        {
            int stokAdet = 0;
            int eksilenDeger = 0;
            int Num;

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            komut = new OleDbCommand("Select * From Depo Where UrunId=" + urunID, baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                tbUrunAd.Text   = oku["UrunAd"].ToString();
                tbUrunAdet.Text = oku["UrunAdet"].ToString();
            }

            bool isNum = int.TryParse(tbDusulecekDeger.Text.ToString(), out Num);
            
            if (isNum)
            {
                stokAdet = int.Parse(tbUrunAdet.Text.ToString());
                eksilenDeger = int.Parse(tbDusulecekDeger.Text.ToString());


                if (tbUrunAdet.Text != "" && Convert.ToInt32(tbUrunAdet.Text.ToString()) > 0 )
                {

                    if (stokAdet >= eksilenDeger)
                    {
                        stokAdet = stokAdet - eksilenDeger;

                        komut = new OleDbCommand("UPDATE Depo SET UrunAdet='" + stokAdet.ToString() + "' WHERE UrunID =" + urunID, baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Değişiklikleriniz kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                        Form1 anaForm = (Form1)Application.OpenForms["Form1"];
                        anaForm.dataGridDoldur("Select * From Depo ORDER BY UrunId");
                    }
                    else if (stokAdet < eksilenDeger)
                    {
                        MessageBox.Show("Stoktaki ürün adedinden fazla ürün girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş Yaptınız.", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hata", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                
                MessageBox.Show("Lütfen Sayısal Bir Değer Girin", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            komut = new OleDbCommand("DELETE FROM Depo WHERE UrunID=" + urunID, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }
    }
}
