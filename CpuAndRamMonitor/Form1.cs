using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpuAndRamMonitor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRam.NextValue();
            progressBarCPU.Value = (int)fcpu;
            progressBarRAM.Value = (int)fram;
            IbiCPU.Text = string.Format("{0:0.0}%", fcpu);
            IbiRAM.Text = string.Format("{0:0.00}%", fram);
            circularProgressBarRam.Value = (int)fram;
            circularProgressBarCPU.Value = (int)fcpu;
            circularProgressBarCPU.SubscriptText = string.Format("{0:0.0}%", fcpu);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
