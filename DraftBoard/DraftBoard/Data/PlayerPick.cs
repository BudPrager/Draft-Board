using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftBoard.Data
{
    public class PlayerPick
    {
        public int PlayerPickID { get; set; }

        public int PlayerID { get; set; }
        public virtual Player Player { get; set; }

        public int RoundID { get; set; }
        public virtual Round Round { get; set; }

        public int FootballerID { get; set; }
        public virtual Footballer Footballer { get; set; }
    }
}
