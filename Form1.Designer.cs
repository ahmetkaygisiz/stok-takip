﻿namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnUrunGoruntule = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnStoktanDus = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnExceleAktar = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoDataSet = new WindowsFormsApplication2.depoDataSet();
            this.depoTableAdapter = new WindowsFormsApplication2.depoDataSetTableAdapters.DepoTableAdapter();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter = new WindowsFormsApplication2.depoDataSetTableAdapters.KategorilerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKonumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(13, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 61);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Yeni Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnUrunGoruntule
            // 
            this.btnUrunGoruntule.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunGoruntule.Location = new System.Drawing.Point(94, 12);
            this.btnUrunGoruntule.Name = "btnUrunGoruntule";
            this.btnUrunGoruntule.Size = new System.Drawing.Size(75, 61);
            this.btnUrunGoruntule.TabIndex = 1;
            this.btnUrunGoruntule.Text = "Ürünü Görüntüle";
            this.btnUrunGoruntule.UseVisualStyleBackColor = true;
            this.btnUrunGoruntule.Click += new System.EventHandler(this.btnUrunGoruntule_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriler.Location = new System.Drawing.Point(417, 12);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(75, 61);
            this.btnKategoriler.TabIndex = 5;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnStoktanDus
            // 
            this.btnStoktanDus.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoktanDus.Location = new System.Drawing.Point(175, 12);
            this.btnStoktanDus.Name = "btnStoktanDus";
            this.btnStoktanDus.Size = new System.Drawing.Size(75, 61);
            this.btnStoktanDus.TabIndex = 2;
            this.btnStoktanDus.Text = "Stoktan Düş";
            this.btnStoktanDus.UseVisualStyleBackColor = true;
            this.btnStoktanDus.Click += new System.EventHandler(this.btnStoktanDus_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(255, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 61);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Değişiklikleri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExceleAktar.Location = new System.Drawing.Point(498, 12);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(75, 61);
            this.btnExceleAktar.TabIndex = 6;
            this.btnExceleAktar.Text = "Excel\'e Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenile.Location = new System.Drawing.Point(336, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 61);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(727, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(727, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdDataGridViewTextBoxColumn,
            this.kategoriAdDataGridViewTextBoxColumn,
            this.urunAdetDataGridViewTextBoxColumn,
            this.urunBirimDataGridViewTextBoxColumn,
            this.urunKonumDataGridViewTextBoxColumn,
            this.UrunID});
            this.dataGridView1.DataSource = this.depoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(870, 450);
            this.dataGridView1.TabIndex = 10;
            // 
            // depoBindingSource
            // 
            this.depoBindingSource.DataMember = "Depo";
            this.depoBindingSource.DataSource = this.depoDataSetBindingSource;
            // 
            // depoDataSetBindingSource
            // 
            this.depoDataSetBindingSource.DataSource = this.depoDataSet;
            this.depoDataSetBindingSource.Position = 0;
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "depoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoTableAdapter
            // 
            this.depoTableAdapter.ClearBeforeFill = true;
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.depoDataSetBindingSource;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::WindowsFormsApplication2.Properties.Resources.Knob_Search;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(727, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "                  Ürün Ara             ";
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunAdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kategoriAdDataGridViewTextBoxColumn
            // 
            this.kategoriAdDataGridViewTextBoxColumn.DataPropertyName = "KategoriAd";
            this.kategoriAdDataGridViewTextBoxColumn.HeaderText = "KategoriAd";
            this.kategoriAdDataGridViewTextBoxColumn.Name = "kategoriAdDataGridViewTextBoxColumn";
            this.kategoriAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriAdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // urunAdetDataGridViewTextBoxColumn
            // 
            this.urunAdetDataGridViewTextBoxColumn.DataPropertyName = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.HeaderText = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.Name = "urunAdetDataGridViewTextBoxColumn";
            this.urunAdetDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunAdetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // urunBirimDataGridViewTextBoxColumn
            // 
            this.urunBirimDataGridViewTextBoxColumn.DataPropertyName = "UrunBirim";
            this.urunBirimDataGridViewTextBoxColumn.HeaderText = "UrunBirim";
            this.urunBirimDataGridViewTextBoxColumn.Name = "urunBirimDataGridViewTextBoxColumn";
            this.urunBirimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunBirimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // urunKonumDataGridViewTextBoxColumn
            // 
            this.urunKonumDataGridViewTextBoxColumn.DataPropertyName = "UrunKonum";
            this.urunKonumDataGridViewTextBoxColumn.HeaderText = "UrunKonum";
            this.urunKonumDataGridViewTextBoxColumn.Name = "urunKonumDataGridViewTextBoxColumn";
            this.urunKonumDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunKonumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UrunID
            // 
            this.UrunID.DataPropertyName = "UrunID";
            this.UrunID.HeaderText = "Ürün ID";
            this.UrunID.Name = "UrunID";
            this.UrunID.ReadOnly = true;
            this.UrunID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UrunID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnStoktanDus);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.btnUrunGoruntule);
            this.Controls.Add(this.btnEkle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sosyal Ben Depo Stok";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnUrunGoruntule;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnStoktanDus;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource depoDataSetBindingSource;
        private depoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private depoDataSetTableAdapters.DepoTableAdapter depoTableAdapter;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private depoDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKonumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
    }
}

