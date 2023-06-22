using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nyp_projem_19._06.DOMAIN;
using System.Collections;



namespace nyp_projem_19._06.DAL
{
    internal class departmanService
    {
        public departmanService() 
        {
        }

    }


    internal class Departman
    {
        private int v1;
        private string v2;
       
        private readonly Func <string> toString;
        public Departman(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
    class departmanDAO
    {
        internal System.Collections.ArrayList departmanlariOku()
        {
            ArrayList okunanDepartmanlar=new ArrayList();
             //büyük harfle yazmamışsın ondan. zaten artık yazarken getiriyor doğrusunu.
            MySqlDataReader okunan = (new MySqlCommand("select*from bolum", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (okunan.Read()) 
            {      // departman diye bir sınıf yok
                okunanDepartmanlar.Add(value:new Departman (Convert.ToInt32(okunan[0]), okunan[1].ToString()));
            }
            
            return okunanDepartmanlar;
        }


        public void departmanKaydet(Departman d)
        {
            (new MySqlCommand("insert into kullanicilar (kullaniciAdi,sifre) value('"+d.P1 +"',+d.P2+"',')".(new dbBaglanti()).baglantiGetir())).ExecuteReader();
        }
    }
}
