namespace Udemy.Tansaction.UI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gondericihesapnumarasi = new System.Windows.Forms.TextBox();
            this.txt_alicihesapnumarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.btn_transaction_aktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(362, 205);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(163, 36);
            this.btn_yenile.TabIndex = 1;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(362, 254);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(65, 39);
            this.btn_kontrol.TabIndex = 2;
            this.btn_kontrol.Text = "Kontrol Et ve Aktar";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gönderici Hesap Numarasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alici Hesap Numarasi";
            // 
            // txt_gondericihesapnumarasi
            // 
            this.txt_gondericihesapnumarasi.Location = new System.Drawing.Point(160, 205);
            this.txt_gondericihesapnumarasi.Name = "txt_gondericihesapnumarasi";
            this.txt_gondericihesapnumarasi.Size = new System.Drawing.Size(182, 20);
            this.txt_gondericihesapnumarasi.TabIndex = 5;
            // 
            // txt_alicihesapnumarasi
            // 
            this.txt_alicihesapnumarasi.Location = new System.Drawing.Point(160, 237);
            this.txt_alicihesapnumarasi.Name = "txt_alicihesapnumarasi";
            this.txt_alicihesapnumarasi.Size = new System.Drawing.Size(182, 20);
            this.txt_alicihesapnumarasi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tutar ₺";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(160, 273);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(182, 20);
            this.txt_tutar.TabIndex = 5;
            // 
            // btn_transaction_aktar
            // 
            this.btn_transaction_aktar.Location = new System.Drawing.Point(460, 255);
            this.btn_transaction_aktar.Name = "btn_transaction_aktar";
            this.btn_transaction_aktar.Size = new System.Drawing.Size(65, 36);
            this.btn_transaction_aktar.TabIndex = 7;
            this.btn_transaction_aktar.Text = "Kontrol Et ve Aktar";
            this.btn_transaction_aktar.UseVisualStyleBackColor = true;
            this.btn_transaction_aktar.Click += new System.EventHandler(this.btn_transaction_aktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 308);
            this.Controls.Add(this.btn_transaction_aktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.txt_alicihesapnumarasi);
            this.Controls.Add(this.txt_gondericihesapnumarasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HesapGörünümü";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gondericihesapnumarasi;
        private System.Windows.Forms.TextBox txt_alicihesapnumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Button btn_transaction_aktar;
    }
}

