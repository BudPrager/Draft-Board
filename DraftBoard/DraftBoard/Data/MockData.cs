using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DraftBoard.Data
{
    public class MockData
    {
        public MockData()
        {
            using (var db = new DraftContext())
            {
                var draft = new Draft { LeagueName = "2 Goals 1 Cup" };
                db.Drafts.Add(draft);
                db.SaveChanges();

                var Teams = new List<Team>()
                {
                    new Team(){ShortName = "TOT", FullName = "Tottenham Hot Spurs" },
                    new Team(){ShortName = "MUN", FullName = "Manchester United" },
                    new Team(){ShortName = "MCI", FullName = "Manchester City"},
                    new Team(){ShortName = "CHE", FullName = "Chelsea"},
                    new Team(){ShortName = "SWA", FullName = "Swansea City"},
                    new Team(){ShortName = "ARS", FullName = "Aresenal"},
                    new Team(){ShortName = "BUR", FullName = "Burnley"},
                    new Team(){ShortName = "LIV", FullName = "Liverpool"},
                    new Team(){ShortName = "SOU", FullName = "Southamptom"},
                    new Team(){ShortName = "CRY", FullName = "Crystal Palace" },
                    new Team(){ShortName = "WHU", FullName = "West Ham United" },
                    new Team(){ShortName = "EVE", FullName = "Everton" },
                    new Team(){ShortName = "BOU", FullName = "Bournmouth"}
                };

                db.Teams.Add(Teams);
                db.SaveChanges();

                var Footballers = new List<Footballer>()
                {
                    new Footballer(){FirstName = "Harry", LastName = "Kane", Team = db.Teams.First(t => t.ShortName == "TOT")},
                };

                var Players = new List<Player>() //TODO - link back to draft with virtual and draft id
                {
                    new Player(){PlayerName = "Jamie"},
                    new Player(){PlayerName = "Matt"},
                    new Player(){PlayerName = "Martyn"},
                    new Player(){PlayerName = "Rich" },
                    new Player(){PlayerName = "Sera" },
                    new Player(){PlayerName = "Mike" },
                    new Player(){PlayerName = "Mark" },
                    new Player(){PlayerName = "Adrian" }
                };
            }
        }
    }
    }
}
