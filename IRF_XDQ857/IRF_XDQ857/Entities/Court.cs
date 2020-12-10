using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_XDQ857.Entities
{
    class Court : Label
    {

        public string Teamname_H;
        public string Teamname_A;
        public string point_H;
        public string point_A;
        public Court()
        {
            Paint += Court_Paint;
            this.Height = 500;
            this.Width = 500;
        }

        private void Court_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
            scoresheet(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            Pen hawk = new Pen(Color.Black);
            Brush spider = new SolidBrush(Color.Gold);

            Rectangle court = new Rectangle(0, 0, 150, 280); // maga  apálya
            Rectangle area_H_1 = new Rectangle(50, 0, 50, 58);
            Rectangle area_A_1 = new Rectangle(50, 222, 50, 58);
            Rectangle circle = new Rectangle(75-18, 140-18, 36, 36); // kis középső kör
            
            g.DrawRectangle(hawk, court);
            g.DrawRectangle(hawk, area_H_1);
            g.DrawRectangle(hawk, area_A_1);

            //g.FillRectangle(spider, curt);
            g.DrawLine(hawk, 0, 140, 150, 140);
            g.DrawEllipse(hawk, circle);

            g.DrawLine(hawk, 10, 0, 10, 30);
            g.DrawLine(hawk, 140, 0, 140, 30);
            g.DrawLine(hawk, 10, 250, 10, 280);
            g.DrawLine(hawk, 140, 250, 140, 280);

            Rectangle semicircle_H = new Rectangle(10,-45, 130, 130);
            g.DrawArc(hawk, semicircle_H, 0, 180);

            Rectangle semicircle_A = new Rectangle(10, 185, 130, 130);
            g.DrawArc(hawk, semicircle_A, 0, -180);


            //Teamname_H = "Hazai";
            //Teamname_A = "Vendég";
            //point_H = "123";
            //point_A = "122";


            


        }

        public void scoresheet(Graphics g)
        {
            g.DrawString(Teamname_H, new Font("Arial", 16), new SolidBrush(Color.Black), 175, 95);
            g.DrawString(Teamname_A, new Font("Arial", 16), new SolidBrush(Color.Black), 175, 145);
            g.DrawString(point_H, new Font("Arial", 16), new SolidBrush(Color.Black), 175, 120);
            g.DrawString(point_A, new Font("Arial", 16), new SolidBrush(Color.Black), 175, 170);
        }
    }

  
}
