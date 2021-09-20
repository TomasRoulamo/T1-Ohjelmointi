using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harjotus14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\Users\\tomas.roulamo\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja.txt");
            teksti += TekstiTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\tomas.roulamo\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja.txt");
            txt.Write(teksti);
            txt.Close();
            Application.Exit();
        }
    }
}
