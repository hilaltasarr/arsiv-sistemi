using nyp_projem_19._06.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyp_projem_19._06.DOMAIN
{
    internal class Evraklar
    {
        private int evrakİd;
        private string evrakAdi;
        private string evrakTipi;

        public string P2
        {
            get { return p2; } set
            { p2 = value; }
        }
        private string p3;

        public string P3
        {
            get { return p3; }
            set { p3 = value; }
        }

        public Evraklar(int p1, string p2, string p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Evraklar(string p11, string p2)
        {
            this.p2 = p11;
            this.p3 = p2;
        }

        public override string ToString()
        {
            return this.p1+","+this.p2+","+this.p3;
        }
    }
}
