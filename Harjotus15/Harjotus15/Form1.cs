using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjotus15
{
    public partial class KelloForm : Form
    {
        private Stopwatch stopWatch;
        public KelloForm()
        {
            InitializeComponent();
        }

        private void AloitaBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }
        private void KelloForm_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void TimerTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}
