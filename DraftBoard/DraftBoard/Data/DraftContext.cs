using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DraftBoard.Data
{
    public class DraftContext : DbContext
    {
        public DbSet<Draft> Drafts { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<PlayerPick> PlayerPicks { get; set; }
    }
}
