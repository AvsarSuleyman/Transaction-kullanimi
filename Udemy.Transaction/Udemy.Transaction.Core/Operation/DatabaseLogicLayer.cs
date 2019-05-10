using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Udemy.Transaction.Core.Operation
{
    public class DatabaseLogicLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int ReturnValueINT;
        bool ReturnValueBL;

        public DatabaseLogicLayer()
        {
            con = new SqlConnection(@"data source=DESKTOP-1I2UQ7S\SA;initial catalog=AddTransaction;user id=sa;password=123");
        }

        public void BaglantiAyar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else
                con.Close();
        }

        public int bankaHesaplaKontrol(string hesapNumarasi)
        {
            cmd = new SqlCommand("select count(*) from Hesap where HesapNumarasi=@hesapNumarasi", con);
            cmd.Parameters.Add("@hesapNumarasi", SqlDbType.NVarChar).Value = hesapNumarasi;
            BaglantiAyar();
            ReturnValueINT = (int)cmd.ExecuteScalar();
            BaglantiAyar();
            return ReturnValueINT;
        }

        public bool bankaHesaplaTutarKontrol(string hesapNumarasi, decimal tutar)
        {
            cmd = new SqlCommand("select count(*) from Hesap where HesapNumarasi=@hesapNumarasi and Tutar<=@tutar", con);
            cmd.Parameters.Add("@hesapNumarasi", SqlDbType.NVarChar).Value = hesapNumarasi;
            cmd.Parameters.Add("@tutar", SqlDbType.Decimal).Value = tutar;
            BaglantiAyar();
            ReturnValueBL = ((int)cmd.ExecuteScalar()) > 0 ? true : false;
            BaglantiAyar();
            return ReturnValueBL;
        }

        public SqlDataReader HesapListe()
        {
            cmd = new SqlCommand("select * from Hesap   ", con);
            BaglantiAyar();
            return cmd.ExecuteReader();
        }

        public int KontroletveAktar(string gonderenHesapNumara, string aliciHesapNumara, decimal tutar)
        {
            int Kontrol = 0;
            cmd = new SqlCommand("select count(*) from Hesap where HesapNumarasi=@gonderenHesapnumarasi", con);
            cmd.Parameters.Add("@gonderenHesapNumarasi", SqlDbType.NVarChar).Value = gonderenHesapNumara;
            BaglantiAyar();
            Kontrol = (int)cmd.ExecuteScalar();
            BaglantiAyar();

            if (Kontrol > 0)
            {
                cmd = new SqlCommand("select count(*) from Hesap where HesapNumarasi=@aliciHesapnumarasi", con);
                cmd.Parameters.Add("@aliciHesapnumarasi", SqlDbType.NVarChar).Value = aliciHesapNumara;
                BaglantiAyar();
                Kontrol = (int)cmd.ExecuteScalar();
                BaglantiAyar();

                if (Kontrol > 0)
                {
                    cmd = new SqlCommand("update Hesap set Tutar=Tutar-@miktar  where HesapNumarasi=@gonderenHesapNumarasi", con);
                    cmd.Parameters.Add("@Miktar", SqlDbType.Decimal).Value = tutar;
                    cmd.Parameters.Add("@gonderenHesapnumarasi", SqlDbType.NVarChar).Value = gonderenHesapNumara;
                    BaglantiAyar();
                    cmd.ExecuteNonQuery();
                    BaglantiAyar();

                    cmd = new SqlCommand("update Hesap set Tutar=Tutar+@miktar  where HesapNumarasi=@aliciHesapNumarasi", con);
                    cmd.Parameters.Add("@Miktar", SqlDbType.Decimal).Value = tutar;
                    cmd.Parameters.Add("@aliciHesapNumarasi", SqlDbType.NVarChar).Value = aliciHesapNumara;
                    BaglantiAyar();
                    cmd.ExecuteNonQuery();
                    BaglantiAyar();


                    cmd = new SqlCommand("insert into HesapLog values (@gonderenHesapNumara,@alanHesapNumara,@tutar,@OlusturmaTarih)", con);
                    cmd.Parameters.Add("@gonderenHesapNumara", SqlDbType.NVarChar).Value = gonderenHesapNumara;
                    cmd.Parameters.Add("@alanHesapNumara", SqlDbType.NVarChar).Value = aliciHesapNumara;
                    cmd.Parameters.Add("@tutar", SqlDbType.Decimal).Value = tutar;
                    cmd.Parameters.Add("@OlusturmaTarih", SqlDbType.DateTime).Value = DateTime.Now;
                    BaglantiAyar();
                    cmd.ExecuteNonQuery();
                    BaglantiAyar();


                }
            }
            return Kontrol;


        }



        public int KontroletveAktarTrans(string gonderenHesapNumara, string aliciHesapNumara, decimal tutar)
        {
            int Kontrol = 0;
            cmd = new SqlCommand("select count(*) from Hesap where HesapNumarasi=@gonderenHesapnumarasi", con);
            cmd.Parameters.Add("@gonderenHesapNumarasi", SqlDbType.NVarChar).Value = gonderenHesapNumara;
            BaglantiAyar();
            Kontrol = (int)cmd.ExecuteScalar();
            BaglantiAyar();

            if (Kontrol > 0)
            {
                cmd = new SqlCommand("select count(*) from Hesap where HesapNumarasi=@aliciHesapnumarasi", con);
                cmd.Parameters.Add("@aliciHesapnumarasi", SqlDbType.NVarChar).Value = aliciHesapNumara;
                BaglantiAyar();
                Kontrol = (int)cmd.ExecuteScalar();
                BaglantiAyar();

                if (Kontrol > 0)
                {
                    //transaction işlemlerine baslayabiliriz.
                    BaglantiAyar();
                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("update Hesap set Tutar=Tutar-@miktar  where HesapNumarasi=@gonderenHesapNumarasi", con, transaction);
                        cmd.Parameters.Add("@Miktar", SqlDbType.Decimal).Value = tutar;
                        cmd.Parameters.Add("@gonderenHesapnumarasi", SqlDbType.NVarChar).Value = gonderenHesapNumara;
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("update Hesap set Tutar=Tutar+@miktar  where HesapNumarasi=@aliciHesapNumarasi", con, transaction);
                        cmd.Parameters.Add("@Miktar", SqlDbType.Decimal).Value = tutar;
                        cmd.Parameters.Add("@aliciHesapNumarasi", SqlDbType.NVarChar).Value = aliciHesapNumara;
                        cmd.ExecuteNonQuery();


                        cmd = new SqlCommand("insert into HesapLog values (@gonderenHesapNumara,@alanHesapNumara,@tutar,@OlusturmaTarih)", con, transaction);
                        cmd.Parameters.Add("@gonderenHesapNumara", SqlDbType.NVarChar).Value = gonderenHesapNumara;
                        cmd.Parameters.Add("@alanHesapNumara", SqlDbType.NVarChar).Value = aliciHesapNumara;
                        cmd.Parameters.Add("@tutar", SqlDbType.Decimal).Value = tutar;
                        cmd.Parameters.Add("@OlsturmaTarih", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                        Kontrol = 1;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Kontrol = -1;
                    }
                    BaglantiAyar();

                }
            }
            return Kontrol;
        }
    }
}
