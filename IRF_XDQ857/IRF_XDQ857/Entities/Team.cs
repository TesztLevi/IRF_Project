using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_XDQ857.Entities
{
    class Team
    {
        public string name { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int physical { get; set; }

        public Player P1;
        public Player P2;
        public Player P3;
        public Player P4;
        public Player P5;
    }
}
