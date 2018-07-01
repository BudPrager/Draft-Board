using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftBoard.Data
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }

        public int DraftID { get; set; }
        public virtual Draft Draft {get;set;}
        public virtual List<PlayerPick> PlayerPicks { get; set; }
    }
}
