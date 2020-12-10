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
        public Court()
        {
            Paint += Court_Paint;
            this.Height = 500;
            this.Width = 500;
        }

        private void Court_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
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



        }
    }

  
}
