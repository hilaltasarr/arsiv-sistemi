using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyp_projem_19._06.DAL
{
    class dbBaglanti
    {
        public MySqlConnection baglantiGetir() 
        {
            MySqlConnection baglanti = new MySqlConnection("Serverlocalhost;Database=hilaldb;Uid=Grup11-2023;pwd=12345");
            baglanti.Open();
            return baglanti;
        }
    }
}
