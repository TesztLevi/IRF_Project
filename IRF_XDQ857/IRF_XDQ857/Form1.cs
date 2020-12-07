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
        Team_UC Team1 = new Team_UC();
        Team_UC Team2 = new Team_UC();

        BindingList<Team_UC> teams = new BindingList<Team_UC>();

        public Form1()
        {
            InitializeComponent();
            


        }

        public void ToolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            panel1.Controls.Add(Team1);
            Team1.Dock = DockStyle.Fill;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();

            panel1.Controls.Add(Team2);
            Team2.Dock = DockStyle.Fill;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            panel1.Controls.Clear();
            panel1.Controls.Add(market);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
