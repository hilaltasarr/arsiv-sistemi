using nyp_projem_19._06.DAL;
using nyp_projem_19._06.SERVÝCE;

namespace nyp_projem_19._06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
       
        internal void departmanKaydet (string text1,string text2) 
        {
            throw new NotImplementedException();
        }
       
        
        internal IEnumerable<Departman> departmanlariOku()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            departmanlariOku();
            foreach (Departman d in (new departmanService()).departmanlariOku())
            {

            }

        }
        private void giristxt_Click(object sender, EventArgs e)
        {
            (new departmanService()).departmanKaydet(kullanýcýadtxt.Text, sifretxt.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new KullanýcýlarService()).kullaniciKaydet(kullaniciaditxt.Text, sifretxt.Text,idtxt.Text);
        }
    }