using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftBoard.Data
{
    public class Footballer
    {
        public int FootballerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }

        public int TeamID { get; set; }
        public virtual Team Team { get; set; }

        public int PlayerPickID { get; set; }
        public virtual PlayerPick PlayerPick { get; set; }
    }
}
