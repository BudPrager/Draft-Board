using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftBoard.Data
{
    public class Draft
    {
        public int DraftID { get; set; }
        public string LeagueName { get; set; }

        public virtual List<Player> Players { get; set; }
        public virtual List<Round> Rounds { get; set; }
    }
}
