using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Transaction.Core.Entities;
using Udemy.Transaction.Core.Operation;

namespace Udemy.Tansaction.UI
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL;

        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile(); 
        }

        void Yenile()
        {
            List<Hesap> hesaplar = BLL.HesapListe();
            dataGridView1.DataSource = hesaplar;
        }

        private void btn_kontrol_Click(object sender, EventArgs e)
        {
            BLL.KontroletveAktar(txt_gondericihesapnumarasi.Text, txt_alicihesapnumarasi.Text, decimal.Parse(txt_tutar.Text));
        }

        private void btn_transaction_aktar_Click(object sender, EventArgs e)
        {
            BLL.KontroletveAktarTrans(txt_gondericihesapnumarasi.Text, txt_alicihesapnumarasi.Text, decimal.Parse(txt_tutar.Text));
        }
    }
}
