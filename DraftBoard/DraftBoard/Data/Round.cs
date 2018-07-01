using System.Collections.Generic;

namespace DraftBoard.Data
{
    public class Round
    {
        public int RoundID { get; set; }
        public string RoundName { get; set; }

        public int DraftID { get; set; }
        public virtual Draft Draft { get; set; }
        public virtual List<PlayerPick> PlayerPicks { get; set; }
    }
}
