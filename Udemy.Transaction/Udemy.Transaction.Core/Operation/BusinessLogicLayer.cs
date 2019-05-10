using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Transaction.Core.Entities;

namespace Udemy.Transaction.Core.Operation
{
    public class BusinessLogicLayer
    {
        DatabaseLogicLayer DLL;

        public BusinessLogicLayer()
        {
            DLL = new DatabaseLogicLayer();
        }

        public int bankaHesaplaKontrol(string hesapNumarasi)
        {
            if (!String.IsNullOrEmpty(hesapNumarasi))
            {
                return DLL.bankaHesaplaKontrol(hesapNumarasi);
            }
            else
            {
                return -1;
            }
        }

        public bool bankaHesaplaTutarKontrol(string hesapNumarasi, decimal tutar)
        {
            if (!string.IsNullOrEmpty(hesapNumarasi) && tutar>0)
            {
                return DLL.bankaHesaplaTutarKontrol(hesapNumarasi,tutar);
            }
            else
            {
                return false;
            }
        }

        public List<Hesap> HesapListe()
        {
            List<Hesap> Hesaplar = new List<Hesap>();
            SqlDataReader reader = DLL.HesapListe();
            while (reader.Read())
            {
                Hesaplar.Add(new Hesap()
                {
                    ID=reader.IsDBNull(0) ? 0:reader.GetInt32(0),
                    HesapNumarasi=reader.IsDBNull(1)? string.Empty:reader.GetString(1),
                    HesapAdi=reader.IsDBNull(2)?string.Empty:reader.GetString(2),
                    Tutar=reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                });
            }
            reader.Close();
            DLL.BaglantiAyar();

            return Hesaplar;
        }

        public int KontroletveAktar(string gonderenHesapNumara,string aliciHesapNumara,decimal tutar)
        {
            return DLL.KontroletveAktar(gonderenHesapNumara, aliciHesapNumara, tutar);
        }

        public int KontroletveAktarTrans(string gonderenHesapNumara, string aliciHesapNumara, decimal tutar)
        {
            return DLL.KontroletveAktarTrans(gonderenHesapNumara, aliciHesapNumara, tutar);
        }


























    }
}
