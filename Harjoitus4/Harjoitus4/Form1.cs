﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SynttariDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365) + " vuotta";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365) + " kuukautta";
            PaivinaLB.Text = (erotus + " päivää");
            TunteinaLB.Text = (erotus * 24 + " tuntia");
            MinuutteinaLB.Text = (erotus *24 *60 + " minuuttia");
            SekunteinaLB.Text = (erotus * 24 * 60 * 60 + " sekuntia");
            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekunteinaLB.Visible = true;
        }
    }
}
