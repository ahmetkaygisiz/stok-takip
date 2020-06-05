using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        // db tanımlamaları
        OleDbConnection     baglanti = new OleDbConnection();
        OleDbCommand        komut    = new OleDbCommand();
        OleDbDataAdapter    adaptor  = new OleDbDataAdapter();
        OleDbCommandBuilder build    = new OleDbCommandBuilder();

        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // pencerenin boyutunun değiştirilememesini sağlar.            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.kategorilerTableAdapter.Fill(this.depoDataSet.Kategoriler);

            // db bağlantı pathi
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + System.Windows.Forms.Application.StartupPath.ToString() + "\\depo.mdb;");

            // ara seçeneği için combobox doldurma
            comboBox1.Items.Add("Ürün Adı");
            comboBox1.Items.Add("Kategoriler");

            dataGridDoldur("SELECT * FROM Depo ORDER BY UrunID");
        }

        // ÜRÜN EKLE PENCERESİ
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.ShowDialog();
        }

        // ÜRÜN BİLGİLERİNİ GÖRÜNTÜLE PENCERESİ
        private void btnUrunGoruntule_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            String a  = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            // DatagridView'den ürün bilgilerini çekip textboxları doldurduk
            u.urunID = Convert.ToInt32(a);
            u.textBox1.Text  = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            u.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            u.textBox3.Text  = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            u.textBox4.Text  = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            u.textBox2.Text  = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
            u.durum = 1;
            u.ShowDialog();
        }

        // ÜRÜN SİLME ve ÜRÜN STOKTAN EKSİLTME 
        private void btnStoktanDus_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 1 )  // Herhangi bir ürün var mı kontrolü.
            {
                StoktanDus stkDus = new StoktanDus();
                String id = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

                stkDus.urunID = Convert.ToInt32(id);
                stkDus.tbUrunAd.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                stkDus.tbUrunAdet.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                stkDus.durum = 1;
                stkDus.ShowDialog();

                dataGridDoldur("SELECT * FROM Depo ORDER BY UrunID");
            }
            else
            {
                MessageBox.Show("Herhangi bir ürün kayıtlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
        }

        // GENEL OLARAK DEĞİŞİKLİKLERİ KAYDETME
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            adaptor.Update(ds.Tables["Depo"]);
            dataGridDoldur("Select * From Depo ORDER BY UrunID");
            MessageBox.Show("Tüm değişiklikler kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // LİSTEYİ YENİLEME
        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridDoldur("Select * From Depo ORDER BY UrunID");
        }

        // KATEGORİLER PENCERESİ
        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.ShowDialog();

        }
        // Excel'e Aktarma 
        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            ExceleAktar();
        }

        public void ExceleAktar()
        {
            try
            { 
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object      Missing = Type.Missing;
                Workbook workbook   = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

                int StartCol = 1;
                int StartRow = 1;

                for (int j= 0; j < dataGridView1.Columns.Count - 1; j++)
                {
                    Range myRange   = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;


                    myRange.Font.Bold = true;
                    myRange.Font.Underline = true;
                    myRange.Worksheet.StandardWidth = 18;
                    System.Drawing.Font f = new System.Drawing.Font("Calibri", 12);
                    myRange.Cells.Font.Size = f.Size;
                }
                StartRow++;

                for (int i = 0; i < dataGridView1.Rows.Count - 1 ; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1 ; j++)
                    {
                        Range myRange   = (Range)sheet1.Cells[StartRow + i,StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                }
            }
            catch
            {

            }

        }

        // DataGridView'i db deki verilerle doldurmak
        public void dataGridDoldur(String komut)
        {
            try
            {  
                ds.Clear();
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                adaptor = new OleDbDataAdapter(komut, baglanti);
                adaptor.Fill(ds, "Depo");
                dataGridView1.DataSource = ds.Tables["Depo"];
                
                adaptor.Dispose();
                baglanti.Close();

                dataGridView1.Columns[0].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Kategori";
                dataGridView1.Columns[2].HeaderText = "Adet";
                dataGridView1.Columns[3].HeaderText = "Birim";
                dataGridView1.Columns[4].HeaderText = "Konum";
                dataGridView1.Columns[5].HeaderText = "UrunID";
            
              
                dataGridView1.Columns[0].Width = 250;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 75;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 250;


                OleDbCommandBuilder builder = new OleDbCommandBuilder(adaptor);
                adaptor.InsertCommand = builder.GetInsertCommand();
                adaptor.UpdateCommand = builder.GetUpdateCommand();
                adaptor.DeleteCommand = builder.GetDeleteCommand();
                
            }
            catch
            {
                
            }
        }

        // ARAMA Seçeneği
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridDoldur("Select * from Depo WHERE KategoriAd Like'" + textBox1.Text + "%'");
                
            }
            else
            {
                dataGridDoldur("Select * from Depo WHERE UrunAd Like'" + textBox1.Text + "%'");
            }
        }
    }
}
