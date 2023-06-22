using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nyp_projem_19._06.DOMAIN;
using nyp_projem_19._06.DAL;

namespace nyp_projem_19._06.SERVİCE
{
    internal class KullanıcılarService
    {
        internal void kullaniciKaydet(int gId, string gKullaniciAdi, string gSifre)
        {
            throw new NotImplementedException();
            (new KullanıcılarDAO()).kullaniciKaydet (new Kullanıcılar(gId, gKullaniciAdi, gSifre));
        }
    }
}
