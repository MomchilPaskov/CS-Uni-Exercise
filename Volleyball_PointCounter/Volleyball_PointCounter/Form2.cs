using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_PointCounter
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer autoCloseTimer;
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            autoCloseTimer = new System.Windows.Forms.Timer();
            autoCloseTimer.Interval = 5000; // 5 seconds
            autoCloseTimer.Tick += AutoCloseTimer_Tick;
        }
        private void AutoCloseTimer_Tick(object sender, EventArgs e)
        {
            autoCloseTimer.Stop();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetWinnerTeam()
        {
            label2.Text = Form1.instance.winner;
            label2.Refresh();
            autoCloseTimer.Start();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
