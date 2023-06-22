using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nyp_projem_19._06.DOMAIN;
using nyp_projem_19._06.DAL;

namespace nyp_projem_19._06.SERVİCE;

class departmanService
{

    internal IEnumerable<Departman> departmanlariOku()
    {
        throw new NotImplementedException();
    }


    internal System.Collections.ArrayList departmanlariOku()
    {
        return (new departmanDAO()).departmanlariOku(); 
    }

    internal void departmanKaydet(int p1, string p2) 
    {
        (new departmanDAO()).departmanKaydet(new Departman(p1 , p2));
    }
}
