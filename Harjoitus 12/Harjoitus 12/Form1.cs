using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_12
{
    public partial class Form1 : Form
    {
        string[] OikeatVastaukset = new string[] { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A" };
        string[] vastaukset = new string[10];
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            VastausRB1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausRB2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausRB3.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausRB4.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                VastausRB1.Enabled = false;
                VastausRB2.Enabled = false;
                VastausRB3.Enabled = false;
                VastausRB4.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == OikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli : " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }

        private void TyhjaaVastaus()
        {
            if (VastausRB1.Checked == true)
            {
                VastausRB1.Checked = false;
                laskuri--;
            }
            if (VastausRB2.Checked == true)
            {
                VastausRB2.Checked = false;
                laskuri--;
            }
            if (VastausRB3.Checked == true)
            {
                VastausRB3.Checked = false;
                laskuri--;
            }
            if (VastausRB4.Checked == true)
            {
                VastausRB4.Checked = false;
                laskuri--;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
