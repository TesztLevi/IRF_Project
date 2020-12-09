﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_XDQ857.Entities;
using System.Xml;

namespace IRF_XDQ857
{


    public partial class Team_UC : UserControl
    {
        BindingList<Player> players = new BindingList<Player>();

        public bool ready { get; set; }

        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }

        public int physical { get; set; }
        public int value { get; set; }

        internal Player P1 { get; set; }
        internal Player P2 { get; set; }
        internal Player P3 { get; set; }
        internal Player P4 { get; set; }
        internal Player P5 { get; set; }











        public Team_UC()
        {
            InitializeComponent();
            xmlLoad();
            comboBox_P1.DataSource = players.ToList();
            comboBox_P1.DisplayMember = "name";
            comboBox_P2.DataSource = players.ToList();
            comboBox_P2.DisplayMember = "name";
            comboBox_P3.DataSource = players.ToList();
            comboBox_P3.DisplayMember = "name";
            comboBox_P4.DataSource = players.ToList();
            comboBox_P4.DisplayMember = "name";
            comboBox_P5.DataSource = players.ToList();
            comboBox_P5.DisplayMember = "name";

            ready = false;
            

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

        private void TextBox_P1_TextChanged(object sender, EventArgs e)
        {
            Kereső_P1();
        }



        private void Kereső_P1()
        {


            comboBox_P1.DataSource = (from p in players
                                      where p.name.StartsWith(textBox_P1.Text)
                                      select p).ToList();
        }

        private void Button_P1_Click(object sender, EventArgs e)
        {
            comboBox_P1.Enabled = false;

            textBox_P1.Visible = false;
            
            button_P1.Enabled = false;
        }

        private void TextBox_P2_TextChanged(object sender, EventArgs e)
        {
            Kereső_P2();
        }

        private void Kereső_P2()
        {
            comboBox_P2.DataSource = (from p in players
                                      where p.name.StartsWith(textBox_P2.Text)
                                      select p).ToList();
        }

        private void Button_P2_Click(object sender, EventArgs e)
        {
            comboBox_P2.Enabled = false;

            textBox_P2.Visible = false;
            
            button_P2.Enabled = false;
        }

        private void TextBox_P3_TextChanged(object sender, EventArgs e)
        {
            Kereső_P3();
        }

        private void Kereső_P3()
        {
            comboBox_P3.DataSource = (from p in players
                                      where p.name.StartsWith(textBox_P3.Text)
                                      select p).ToList();
        }

        private void Button_P3_Click(object sender, EventArgs e)
        {
            comboBox_P3.Enabled = false;

            textBox_P3.Visible = false;
            
            button_P3.Enabled = false;
        }

        private void TextBox_P4_TextChanged(object sender, EventArgs e)
        {
            Kereső_P4();
        }

        private void Kereső_P4()
        {
            comboBox_P4.DataSource = (from p in players
                                      where p.name.StartsWith(textBox_P4.Text)
                                      select p).ToList();
        }

        private void Button_P4_Click(object sender, EventArgs e)
        {
            comboBox_P4.Enabled = false;

            textBox_P4.Visible = false;
            
            button_P4.Enabled = false;
        }

        private void TextBox_P5_TextChanged(object sender, EventArgs e)
        {
            Kereső_P5();
        }

        private void Kereső_P5()
        {
            comboBox_P5.DataSource = (from p in players
                                      where p.name.StartsWith(textBox_P5.Text)
                                      select p).ToList();
        }

        private void Button_P5_Click(object sender, EventArgs e)
        {
            comboBox_P5.Enabled = false;

            textBox_P5.Visible = false;
            button_P5.Enabled = false;

            button_unsign.Visible = true;

        }



        public void Button_ready_Click_1(object sender, EventArgs e)
        {
            if (textBox_T_name.TextLength > 3)
            {
                textBox_T_name.Enabled = false;

                Player p1 = (Player)comboBox_P1.SelectedItem;
                Player p2 = (Player)comboBox_P2.SelectedItem;
                Player p3 = (Player)comboBox_P3.SelectedItem;
                Player p4 = (Player)comboBox_P4.SelectedItem;
                Player p5 = (Player)comboBox_P5.SelectedItem;

                P1 = p1;
                P2 = p2;
                P3 = p3;
                P4 = p4;
                P5 = p5;

                name = textBox_T_name.Text;
                attack = (p1.attack + p2.attack + p3.attack + p4.attack + p5.attack) / 5;
                defense = (p1.defense + p2.defense + p3.defense + p4.defense + p5.defense) / 5;
                physical = (p1.physical + p2.physical + p3.physical + p4.physical + p5.physical) / 5;
                MessageBox.Show("Gratulálunk, készen van a csapatod!"+ready);
                button_ready.Enabled = false;
                ready = true;
            }
            else
            {
                MessageBox.Show("Kérlek add meg a Csapatod nevét is!");
            }
            
            //MessageBox.Show("Csapatod neve:" + name + " Attack: " + attack.ToString() + " Defense:" + defense.ToString() + physical.ToString());
        }

        private void Button_ready_MouseHover(object sender, EventArgs e)
        {
            label_hint.Visible = true;
        }

        private void Button_ready_MouseLeave(object sender, EventArgs e)
        {
            label_hint.Visible = false;
            
        }

        private void Button_unsign_Click(object sender, EventArgs e)
        {
            comboBox_P1.Enabled = true;
            comboBox_P2.Enabled = true;
            comboBox_P3.Enabled = true;
            comboBox_P4.Enabled = true;
            comboBox_P5.Enabled = true;





            textBox_P1.Visible = true;
            textBox_P2.Visible = true;
            textBox_P3.Visible = true;
            textBox_P4.Visible = true;
            textBox_P5.Visible = true;

            button_P1.Enabled = true;
            button_P2.Enabled = true;
            button_P3.Enabled = true;
            button_P4.Enabled = true;
            button_P5.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ready.ToString());
        }
    }
}

