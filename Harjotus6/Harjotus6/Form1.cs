using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjotus6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void SalasanaOikeinPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Tomas" && SalasanaTB.Text == "moi123")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;

            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnut tai salasana on väärin!";
                VirheviestiLB.Visible = true;
            }
        }
    }
}
