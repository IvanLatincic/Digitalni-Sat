using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace dig_sat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerHR_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("HH:mm");
            secondslabel.Text = DateTime.Now.ToString("ss");
            datelabel.Text = DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("hr-HR"));
        }

        private void timerUS_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("hh:mm tt", CultureInfo.CreateSpecificCulture("en-US"));
            secondslabel.Text = DateTime.Now.ToString("ss");
            datelabel.Text = DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void timerDE_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("HH:mm");
            secondslabel.Text = DateTime.Now.ToString("ss");
            datelabel.Text = DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"));
        }

        private void timerUK_Tick(object sender, EventArgs e)
        {
            timelabel.Text = DateTime.Now.ToString("HH:mm");
            secondslabel.Text = DateTime.Now.ToString("ss");
            datelabel.Text = DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("en-GB"));
        }

        private void buttonHR_Click(object sender, EventArgs e)
        {
            timerHR.Start();
            timerUS.Dispose();
            timerDE.Dispose();
            timerUK.Dispose();
        }

        private void buttonUS_Click(object sender, EventArgs e)
        {
            timerUS.Start();
            timerHR.Dispose();
            timerDE.Dispose();
            timerUK.Dispose();
        }

        private void buttonDE_Click(object sender, EventArgs e)
        {
            timerDE.Start();
            timerHR.Dispose();
            timerUS.Dispose();
            timerUK.Dispose();

        }

        private void buttonUK_Click(object sender, EventArgs e)
        {
            timerUK.Start();
            timerHR.Dispose();
            timerUS.Dispose();
            timerDE.Dispose();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
