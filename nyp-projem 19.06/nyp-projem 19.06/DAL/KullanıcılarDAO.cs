using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using nyp_projem_19._06.DOMAIN;

namespace nyp_projem_19._06.DAL
{
    internal class KullanıcılarDAO
    {
        public void kullaniciKaydet (Kullanıcılar gkullanıcılar)
        {
            (new MySqlCommand ("insert into kullanicilar (id,kullaniciAdi,sifre) values ('" + gkullanıcılar.Id + "'," + gkullanıcılar.KullaniciAdi + "," + gkullanıcılar.Sifre + ")", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
        }
    }
}
