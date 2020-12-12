using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using IRF_XDQ857.Entities;

namespace IRF_XDQ857
{
    public partial class Form1 : Form
    {
       

        BindingList<Team_UC> teams = new BindingList<Team_UC>();
        BindingList<Match_UC> matchs = new BindingList<Match_UC>();
        
        
        public Team_UC Team_H { get; set; }
        public Team_UC Team_A { get; set; }

         
        public bool ready_A;
        public bool ready_H;



        public Form1()
        {
            InitializeComponent();
           


        }

        public void ToolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Team_UC Team1 = new Team_UC();
            Team_H = Team1;
            panel1.Controls.Add(Team1);
            Team1.Dock = DockStyle.Fill;

            button_matchstart.Enabled = false;
            
        }

        

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            panel1.Controls.Clear();
            panel1.Controls.Add(market);
        }

       

        private void button_matchstart_Click(object sender, EventArgs e)
        {
            
                panel1.Controls.Clear();

                Random r = new Random();
                Match_UC match = new Match_UC();
                panel1.Controls.Add(match);
                match.team1 = Team_H;
                match.team2 = Team_A;
                match.HForm = Team_H.physical / 10;
                match.AForm = Team_A.physical / 10;
            
                match.H_name = Team_H.name;
                match.A_name = Team_A.name;

                matchs.Add(match);

                button_awayteam.Enabled = false;
           


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                ready_H = Team_H.ready;
            }
            catch (Exception)
            {
               
            }

            try
            {
                ready_A = Team_A.ready;
            }
            catch (Exception)
            {

            }

            if (ready_H == true)
            {
                button_awayteam.Enabled = true;
            }
            if (ready_A == true)
            {
                button_matchstart.Enabled = true;
            }
        }

        private void Button_awayteam_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Team_UC Team2 = new Team_UC();
            Team_A = Team2;
            panel1.Controls.Add(Team2);
            Team2.Dock = DockStyle.Fill;
        }

        private void MeccsekKiírásaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
