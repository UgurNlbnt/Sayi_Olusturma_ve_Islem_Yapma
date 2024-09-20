namespace uğur_nalbant_ödev
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
            this.grpsayıolustur = new System.Windows.Forms.GroupBox();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.btnolustur = new System.Windows.Forms.Button();
            this.grphesapla = new System.Windows.Forms.GroupBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbislem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.grpsayıolustur.SuspendLayout();
            this.grphesapla.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpsayıolustur
            // 
            this.grpsayıolustur.Controls.Add(this.lstBox2);
            this.grpsayıolustur.Controls.Add(this.lstBox1);
            this.grpsayıolustur.Controls.Add(this.btnolustur);
            this.grpsayıolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpsayıolustur.Location = new System.Drawing.Point(44, 33);
            this.grpsayıolustur.Name = "grpsayıolustur";
            this.grpsayıolustur.Size = new System.Drawing.Size(392, 371);
            this.grpsayıolustur.TabIndex = 0;
            this.grpsayıolustur.TabStop = false;
            this.grpsayıolustur.Text = "1-1000 arasında rasgele 20 sayı oluşturur ve sıralı bir şekilde listelere dolduru" +
    "r.";
            // 
            // lstBox2
            // 
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.ItemHeight = 20;
            this.lstBox2.Location = new System.Drawing.Point(206, 117);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(162, 244);
            this.lstBox2.TabIndex = 4;
            // 
            // lstBox1
            // 
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.ItemHeight = 20;
            this.lstBox1.Location = new System.Drawing.Point(18, 117);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(164, 244);
            this.lstBox1.TabIndex = 3;
            // 
            // btnolustur
            // 
            this.btnolustur.Location = new System.Drawing.Point(121, 68);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(127, 32);
            this.btnolustur.TabIndex = 0;
            this.btnolustur.Text = "OLUŞTUR";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // grphesapla
            // 
            this.grphesapla.Controls.Add(this.btnhesapla);
            this.grphesapla.Controls.Add(this.lblsonuc);
            this.grphesapla.Controls.Add(this.label2);
            this.grphesapla.Controls.Add(this.cmbislem);
            this.grphesapla.Controls.Add(this.label1);
            this.grphesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grphesapla.Location = new System.Drawing.Point(501, 33);
            this.grphesapla.Name = "grphesapla";
            this.grphesapla.Size = new System.Drawing.Size(266, 371);
            this.grphesapla.TabIndex = 1;
            this.grphesapla.TabStop = false;
            this.grphesapla.Text = "HESAPLA";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(110, 159);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 20);
            this.lblsonuc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SONUÇ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbislem
            // 
            this.cmbislem.FormattingEnabled = true;
            this.cmbislem.Location = new System.Drawing.Point(103, 45);
            this.cmbislem.Name = "cmbislem";
            this.cmbislem.Size = new System.Drawing.Size(134, 28);
            this.cmbislem.TabIndex = 1;
            this.cmbislem.SelectedIndexChanged += new System.EventHandler(this.cmbislem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İŞLEM";
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(103, 102);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(123, 32);
            this.btnhesapla.TabIndex = 4;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.grphesapla);
            this.Controls.Add(this.grpsayıolustur);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞLEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpsayıolustur.ResumeLayout(false);
            this.grphesapla.ResumeLayout(false);
            this.grphesapla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpsayıolustur;
        private System.Windows.Forms.ListBox lstBox2;
        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.GroupBox grphesapla;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbislem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhesapla;
    }
}

