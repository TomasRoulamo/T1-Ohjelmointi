using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjotus16
{
    public partial class LaskuriForm : Form
    {
        public LaskuriForm()
        {
            InitializeComponent();
        }

        private int kokonaisaika;
        private void LaskuriForm_Load(object sender, EventArgs e)
        {
            LopetaBT.Enabled = false;
            for (int i=0; i < 60; i++)
            {
                MinuuttiCB.Items.Add(i.ToString());
                SekunttiCB.Items.Add(i.ToString());
            }
            MinuuttiCB.SelectedIndex = 0;
            SekunttiCB.SelectedIndex = 10;
        }

        private void AloitaBT_Click(object sender, EventArgs e)
        {
            AloitaBT.Enabled = false;
            LopetaBT.Enabled = true;
            int minuutit = int.Parse(MinuuttiCB.SelectedItem.ToString());
            int sekuntit = int.Parse(SekunttiCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekuntit;
            AjastinTM.Enabled = true;
            AikaLB.Text = "00:00";
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            AloitaBT.Enabled = true;
            LopetaBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
         
        }

        private void AjastinTM_Tick_1(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekuntit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekuntit.ToString();

            }

            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui");
            }
        }
    }
}
