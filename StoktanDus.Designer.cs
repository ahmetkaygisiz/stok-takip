namespace WindowsFormsApplication2
{
    partial class StoktanDus
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
            this.btnDegisiklikKaydet = new System.Windows.Forms.Button();
            this.tbUrunAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbDusulecekDeger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDegisiklikKaydet
            // 
            this.btnDegisiklikKaydet.Location = new System.Drawing.Point(26, 111);
            this.btnDegisiklikKaydet.Name = "btnDegisiklikKaydet";
            this.btnDegisiklikKaydet.Size = new System.Drawing.Size(116, 30);
            this.btnDegisiklikKaydet.TabIndex = 4;
            this.btnDegisiklikKaydet.Text = "Kaydet";
            this.btnDegisiklikKaydet.UseVisualStyleBackColor = true;
            this.btnDegisiklikKaydet.Click += new System.EventHandler(this.btnDegisiklikKaydet_Click);
            // 
            // tbUrunAdet
            // 
            this.tbUrunAdet.Enabled = false;
            this.tbUrunAdet.Location = new System.Drawing.Point(86, 38);
            this.tbUrunAdet.Name = "tbUrunAdet";
            this.tbUrunAdet.Size = new System.Drawing.Size(175, 20);
            this.tbUrunAdet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Stok Adedi";
            // 
            // tbUrunAd
            // 
            this.tbUrunAd.Enabled = false;
            this.tbUrunAd.Location = new System.Drawing.Point(86, 12);
            this.tbUrunAd.Name = "tbUrunAd";
            this.tbUrunAd.Size = new System.Drawing.Size(175, 20);
            this.tbUrunAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün Adı";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(75, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ürünü Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbDusulecekDeger
            // 
            this.tbDusulecekDeger.Location = new System.Drawing.Point(86, 68);
            this.tbDusulecekDeger.Name = "tbDusulecekDeger";
            this.tbDusulecekDeger.Size = new System.Drawing.Size(175, 20);
            this.tbDusulecekDeger.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adet";
            // 
            // StoktanDus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.tbDusulecekDeger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDegisiklikKaydet);
            this.Controls.Add(this.tbUrunAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUrunAd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoktanDus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StoktanDus";
            this.Load += new System.EventHandler(this.StoktanDus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDegisiklikKaydet;
        public System.Windows.Forms.TextBox tbUrunAdet;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbDusulecekDeger;
    }
}