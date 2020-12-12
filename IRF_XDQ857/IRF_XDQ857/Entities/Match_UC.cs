using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_XDQ857.Entities
{
    public partial class Match_UC : UserControl
    {
        public Team_UC team1 { get; set; }
        public Team_UC team2 { get; set; }

        public int HQ;
        
        public int AQ;

        public int HS;
        public int AS;


        Random r = new Random();

        public int HForm;
        public int AForm;

        

        public string H_name;
        public string A_name;

        



        public Match_UC()
        {
            InitializeComponent();
            
            HS = 0;
            AS = 0;
            

            Paint += Match_UC_Paint;
           
            
        }

        private void Match_UC_Paint(object sender, PaintEventArgs e)
        {
            Court c = new Court();
            panel_grapics.Controls.Add(c);
            c.Teamname_H = H_name;
            c.Teamname_A = A_name;
            c.point_H = HS.ToString();
            c.point_A = HQ.ToString();
            
        }

        private void MatchEngine()
        {
            HQ = (team1.attack - r.Next(-(15 - HForm), HForm)) * (team1.attack - r.Next(-(15 - HForm), HForm)) / (team2.defense - r.Next(-(15 - AForm), AForm)) / 4;
            AQ = (team2.attack - r.Next(-(15 - AForm), AForm)) * (team2.attack - r.Next(-(15 - AForm), AForm)) / (team1.defense - r.Next(-(15 - HForm), HForm)) / 4;
            HS = HS + HQ;
            AS = AS + AQ;
            MessageBox.Show(HForm.ToString() + "   " + AForm.ToString());
        }
        private void Button1_Click(object sender, EventArgs e) 
        {
            MatchEngine();
           
            label1.Text = HQ.ToString();
           
            label2.Text = AQ.ToString();
            Scorerefresh();
            button1.Visible = false;
            button2.Visible = true;

        }

        private void Scorerefresh()
        {
            panel_grapics.Controls.Clear();
            Court c = new Court();
            panel_grapics.Controls.Add(c);
            c.Teamname_H = H_name;
            c.Teamname_A = A_name;
            c.point_H = HS.ToString();
            c.point_A = AS.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MatchEngine();
            
            label3.Text = HQ.ToString();
            label4.Text = AQ.ToString();
            Scorerefresh();
            button2.Visible = false;
            button3.Visible = true;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MatchEngine();
            
            label5.Text = HQ.ToString();
            label6.Text = AQ.ToString();
            Scorerefresh();
            button3.Visible = false;
            button4.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MatchEngine();
            
            label7.Text = HQ.ToString();
            label8.Text = AQ.ToString();
            Scorerefresh();
            button4.Visible = false;
            button5.Visible = true;
            button6.Visible = true;

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button5.Visible = false;
            HS = 0;
            AS = 0;
            Scorerefresh();
            HQ = 0;
            AQ = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
