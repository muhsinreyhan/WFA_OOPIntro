using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            Bilgisayar bilgisayar = new Bilgisayar();

            bilgisayar.marka = "Dell";
            bilgisayar.islemci = "i7";
            bilgisayar.ramBoyutu = 16;
            bilgisayar.ekranKartı = "GTX 1050";

            MessageBox.Show(string.Format("Marka: {0}\nİşlemci: {1}\nRam: {2}\nEkran Kartı {3}", bilgisayar.marka, bilgisayar.islemci, bilgisayar.ramBoyutu, bilgisayar.ekranKartı));
        }
    }
}
