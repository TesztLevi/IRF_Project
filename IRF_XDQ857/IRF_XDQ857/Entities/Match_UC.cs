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

        Random r = new Random();

        public int HForm;
        public int AForm;

        public int H1;
        public int H2;
        public int H3;
        public int H4;
        public int A1;
        public int A2;
        public int A3;
        public int A4;





        public Match_UC()
        {
            InitializeComponent();
            
           
        }

        private void MatchEngine()
        {
            HQ = ((team1.attack - r.Next(-10, 10)) * (team1.attack - r.Next(-10, 10)) / team2.defense) / 4;
            AQ = ((team2.attack - r.Next(-10, 10)) * (team2.attack - r.Next(-10, 10)) / team1.defense) / 4;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            MatchEngine();
            H1 = HQ;
            A1 = AQ;
            label1.Text = H1.ToString();
           
            label2.Text = A1.ToString();

            

        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            MatchEngine();
            H2 = H1+HQ;
            A2 = A1+AQ;
            label3.Text = HQ.ToString();
            label4.Text = AQ.ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MatchEngine();
            H3 = H2 + HQ;
            A3 = A2 + AQ;
            label5.Text = HQ.ToString();
            label6.Text = AQ.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MatchEngine();
            H4 = H3 + HQ;
            A4 = A3 + AQ;
            label7.Text = HQ.ToString();
            label8.Text = AQ.ToString();
            MessageBox.Show(H4.ToString()+" - " + A4.ToString());
        }
    }
}
