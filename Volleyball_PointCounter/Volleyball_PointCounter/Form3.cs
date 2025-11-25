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
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            Form3.instance = this;
        }

        public bool Done = false;
        public int goal_points = 0;
        public string team1_name = "";
        public string team2_name = "";

        public void setNamesAndPoints()
        {
            team1_name = textBox1.Text;
            team2_name = textBox2.Text;
            goal_points = int.Parse(textBox3.Text);
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

         
        
    }
}
