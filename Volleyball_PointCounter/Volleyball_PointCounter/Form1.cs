using System.Security.Cryptography.X509Certificates;

namespace Volleyball_PointCounter
{
    public partial class Form1 : Form
    {

        public static Form1 instance;


        int clicked_settings = 0;
        int team1 = 0;
        int team2 = 0;
        public int team1_sets = 0;
        public int team2_sets = 0;
        int diff = 0;
        bool game_over = false;
        string TeamName1 = "Team 1";
        string TeamName2 = "Team 2";
        int scoreGoal = 25;
        public string winner = "0";
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();


        




        public void ChangeNamesAndScoreGoal()
        {
            Form3.instance.setNamesAndPoints();

            scoreGoal = Form3.instance.goal_points;
            TeamName1 = Form3.instance.team1_name;
            TeamName2 = Form3.instance.team2_name;

            button1.Text = TeamName1;
            button2.Text = TeamName2;
            label6.Text = TeamName1;
            label7.Text = TeamName2;

            button1.Refresh();
            button2.Refresh();
            label6.Refresh();
            label7.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public void CheckForWinner()
        {
            if (team1_sets == 2)
            {

                game_over = true;
                winner = TeamName1;
                Form2.instance.SetWinnerTeam();
            }
            else if (team2_sets == 2)
            {

                game_over = true;
                winner = TeamName2;
                Form2.instance.SetWinnerTeam();

            }


            if (game_over)
            {

                form2.Show();
                team1 = 0;
                team2 = 0;
                team1_sets = 0;
                team2_sets = 0;
                label1.Text = "0";
                label2.Text = "0";
                label4.Text = "0";
                label5.Text = "0";
                label1.Refresh();
                label2.Refresh();
                label4.Refresh();
                label5.Refresh();
                game_over = false;
                winner = "0";
            }

        }

        public void CheckScore()
        {
            diff = Math.Abs(team1 - team2);
            if (team1 >= scoreGoal && team1 > team2 && diff >= 2)
            {
                team1 = 0;
                team2 = 0;
                team1_sets++;
                label4.Text = team1_sets.ToString();
                label2.Text = team2.ToString();
                label1.Text = team1.ToString();
                label1.Refresh();
                label2.Refresh();

            }
            else if (team2 >= scoreGoal && team2 > team1 && diff >= 2)
            {
                team1 = 0;
                team2 = 0;
                team2_sets++;
                label5.Text = team2_sets.ToString();
                label2.Text = team2.ToString();
                label1.Text = team1.ToString();
                label1.Refresh();
                label2.Refresh();

            }
            else
            {
                label2.Text = team2.ToString();
                label1.Text = team1.ToString();
            }
            label1.Refresh();
            label2.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            team1++;
            CheckScore();
            label1.Refresh();
            CheckForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            team2++;
            CheckScore();
            label2.Refresh();
            CheckForWinner();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            clicked_settings++;

            if (clicked_settings % 2 == 1)
            {
                form3.Show();
                button3.Text = "Close Settings";
            }
            else 
            {
                ChangeNamesAndScoreGoal();
                team1 = 0;
                team2 = 0;
                label1.Text = "0";
                label2.Text = "0";
                label1.Refresh();
                label2.Refresh();

                form3.Hide();
                button3.Text = "Open Settings";
            }
            
        }
    }
}
