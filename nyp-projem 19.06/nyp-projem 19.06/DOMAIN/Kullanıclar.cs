using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyp_projem_19._06.DOMAIN
{
    public class Kullanıcılar

        
    {
        public Kullanıcılar(int gId,string gKullaniciAdi, string gSifre )
        {
            this.Id= gId ;
            this.kullaniciAdi = gKullaniciAdi;
            this.Sifre= gSifre ;
        }


        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }


       
    }
}
