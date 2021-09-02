using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KmvuosiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainakorkoTB);
            nesteet = Convert.ToDouble(NesteetTB);
            vakuutus = Convert.ToDouble(VakuutusTB);
            pesut = Convert.ToDouble(PesuTB);
            huollot = Convert.ToDouble(HuollotTB);
            renkaat = Convert.ToDouble(RenkaatTB);
            muut = Convert.ToDouble(MuutkulutTB);
            energia = Convert.ToDouble(PolttoaineTB);
            kilometrit = Convert.ToDouble(KmvuosiCB);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + energia + renkaat + muut) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
        }
    }
}
