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
        BindingList<Player> players = new BindingList<Player>();
        BindingList<Team> teams = new BindingList<Team>();

        public Form1()
        {
            InitializeComponent();
            xmlLoad();

            
            comboBox_T1P1.DataSource = players.ToList();
            comboBox_T1P1.DisplayMember = "name";
            comboBox_T1P2.DataSource = players.ToList();
            comboBox_T1P2.DisplayMember = "name";

        }

        private void xmlLoad()
        {
            var xml = new XmlDocument();
            xml.Load("XML/IRF_Players.xml");

            foreach (XmlElement element in xml.DocumentElement)
            {

                var player = new Player();
                players.Add(player);
               

                player.name = (element.GetAttribute("name"));


                var childElement = (XmlElement)element.ChildNodes[0];
                player.attack = int.Parse(childElement.GetAttribute("att"));
                player.defense = int.Parse(childElement.GetAttribute("def"));
                player.physical = int.Parse(childElement.GetAttribute("phy"));

                var prize = int.Parse(childElement.InnerText);

                player.prize = prize;
            }
        }

        private void TextBox_T1P1_TextChanged(object sender, EventArgs e)
        {
            Kereső_T1P1();
        }

        private void Kereső_T1P1()
        {
                           

            comboBox_T1P1.DataSource = (from p in players
                                    where p.name.StartsWith(textBox_T1P1.Text)
                                    select p).ToList();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            comboBox_T1P1.Enabled = false;
            textBox_T1P1.Visible = false;
            textBox_T1P2.Visible = true;
        }

        private void TextBox_T1P2_TextChanged(object sender, EventArgs e)
        {
            Kereső_T1P2();
        }

        private void Kereső_T1P2()
        {
            comboBox_T1P2.DataSource = (from p in players
                                        where p.name.StartsWith(textBox_T1P2.Text)
                                        select p).ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox_T1P2.Enabled = false;
            textBox_T1P2.Visible = false;
            //textBox_T1P2.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           //player 1
            Player t1p1 = (Player)comboBox_T1P1.SelectedItem;

            var name1 = from n in players
                     where n.name == t1p1.name
                     select n.name;

            var att1 = from p1a in players
                      where p1a.attack == t1p1.attack
                      select p1a.attack;

            //player2


            Player t1p2 = (Player)comboBox_T1P2.SelectedItem;

            var name2 = from n in players
                        where n.name == t1p2.name
                        select n.name;

            var att2 = from p1a in players
                       where p1a.attack == t1p2.attack
                       select p1a.attack;

            Team t = new Team();

            t.P1 = t1p1;
            t.P2 = t1p2;
            t.name = textBox1.Text;
            t.attack = t1p1.attack + t1p2.attack;

            string próba = (t.attack * 2).ToString();

            teams.Add(t);
            
            MessageBox.Show("Csapatod neve:" + t.name + " Attack: " + próba);
        }
    }
}
