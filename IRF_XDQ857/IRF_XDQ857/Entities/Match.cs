using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_XDQ857.Entities
{
    class Match
    {
        public Team_UC team1 { get; set; }
        public Team_UC team2 { get; set; }

        

        public int HQ1;
        public int HQ2;
        public int HQ3;
        public int HQ4;
        public int AQ1;
        public int AQ2;
        public int AQ3;
        public int AQ4;

        Random r = new Random();

        public Match()
        {
            

            
            Engine();


        }

        private void Engine()
        {
            //int HomeRandom = 20 - Team1.physical/5;
            //int AwayRandom = 20 - Team2.physical / 5;

            //HQ1 = ((Team1.attack - r.Next(-10, 10)) ^ 2)/(Team2.defense-r.Next(-10, 10));
        }
    }
}
