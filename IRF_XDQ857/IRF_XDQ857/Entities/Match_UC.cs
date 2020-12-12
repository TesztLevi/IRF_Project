using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IRF_XDQ857.Entities
{
    public partial class Match_UC : UserControl
    {
        public Team_UC team1 { get; set; }
        public Team_UC team2 { get; set; }

        public DateTime matchstart;

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
            matchstart = DateTime.Now;
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
            
        }
        private void Button1_Click(object sender, EventArgs e) 
        {
            MatchEngine();
           
            label1.Text = HQ.ToString();
           
            label2.Text = AQ.ToString();
            Scorerefresh();
            button1.Visible = false;
            button1.Enabled = false;
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
            button2.Enabled = false;
            button3.Visible = true;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MatchEngine();
            
            label5.Text = HQ.ToString();
            label6.Text = AQ.ToString();
            Scorerefresh();
            button3.Visible = false;
            button3.Enabled = false;
            button4.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MatchEngine();
            
            label7.Text = HQ.ToString();
            label8.Text = AQ.ToString();
            Scorerefresh();
            button4.Visible = false;
            button4.Enabled = false;
            button6.Visible = true;
            label15.Visible = true;

            Result();

        }

        private void Result()
        {
            if (HS > AS)
            {
                label16.Text = ("A(z) " + H_name + " nyert " + (HS - AS).ToString() + " pontal!");
            }
            else if (AS>HS)
            {
                label16.Text = ("A(z) " + A_name + " nyert " + (AS - HS).ToString() + " pontal!");
            }
            else
            {
                label16.Text = ("Döntetlen lett a mérkőzés!");
            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sf.FileName, false, Encoding.UTF8))
            {

                

                    sw.Write(team1.name);
                    sw.Write(";");
                    sw.Write(team1.P1.name);
                    sw.Write(";");
                    sw.Write(team1.P2.name);
                    sw.Write(";");
                    sw.Write(team1.P3.name);
                    sw.Write(";");
                    sw.Write(team1.P4.name);
                    sw.Write(";");
                    sw.Write(team1.P5.name);
                    sw.Write(";");
                    sw.Write(team1.attack.ToString());
                    sw.Write(";");
                    sw.Write(team1.defense.ToString());
                    sw.Write(";");
                    sw.Write(team1.physical.ToString());
                    sw.Write(";");
                    sw.Write(team1.value.ToString());
                    sw.Write(";");
                    sw.Write(HS.ToString());
                    sw.Write(";");

                    sw.WriteLine();

                    sw.Write(team2.name);
                    sw.Write(";");
                    sw.Write(team2.P1.name);
                    sw.Write(";");
                    sw.Write(team2.P2.name);
                    sw.Write(";");
                    sw.Write(team2.P3.name);
                    sw.Write(";");
                    sw.Write(team2.P4.name);
                    sw.Write(";");
                    sw.Write(team2.P5.name);
                    sw.Write(";");
                    sw.Write(team2.attack.ToString());
                    sw.Write(";");
                    sw.Write(team2.defense.ToString());
                    sw.Write(";");
                    sw.Write(team2.physical.ToString());
                    sw.Write(";");
                    sw.Write(team2.value.ToString());
                    sw.Write(";");
                    sw.Write(AS.ToString());
                    sw.Write(";");

                    sw.WriteLine();

            }

        }
    }
}
