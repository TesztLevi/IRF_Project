using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_XDQ857.Entities
{
    public partial class Market : UserControl
    {
        BindingList<Player> players = new BindingList<Player>();

        
        public Market()
        {
            InitializeComponent();
            xmlLoad();
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

        private void Market_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Cip cipő = (Cipők)listBox1.SelectedItem;

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            
            



            var attack = from a in players
                         where a.attack > int.Parse(textBox1.Text) && a.defense > int.Parse(textBox2.Text)
                         
                         select new
                         {
                             Név = a.name,
                             Támadás = a.attack + r.Next(-3,4),
                             Védekezés = a.defense + r.Next(-3, 4),
                             Fizikum = a.physical + r.Next(-3, 4),
                             Ár = a.prize,

                         };
            dataGridView1.DataSource = attack.ToList();
        }
    }
}
