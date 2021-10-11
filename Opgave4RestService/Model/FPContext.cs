using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootBallLib;
using Microsoft.EntityFrameworkCore;

namespace Opgave4RestService.Model
{
    public class FPContext : DbContext
    {
        public FPContext(DbContextOptions<FPContext> options) : 
            base(options)
        {
            
        }

        public DbSet<FootballPlayer> FootballPlayers { get; set; }
    }
}
