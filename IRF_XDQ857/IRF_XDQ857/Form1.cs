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
        PreGame_UC Team1 = new PreGame_UC();
        PreGame_UC Team2 = new PreGame_UC();

        public Form1()
        {
            InitializeComponent();
            


        }

        public void ToolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            panel1.Controls.Add(Team1);
            Team1.Dock = DockStyle.Fill;
            
            


            panel2.Controls.Clear();
            
            panel2.Controls.Add(Team2);
            Team2.Dock = DockStyle.Fill;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Team1.tam.ToString());
            button1.Text = "Visszavágó";
        }
    }
}
