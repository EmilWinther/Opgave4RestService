using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootBallLib;
using Opgave4RestService.Model;

namespace Opgave4RestService.Managers
{
    public class ManageFpDB
    {
        private readonly FPContext _context;

        public ManageFpDB(FPContext context)
        {
            _context = context;
        }

        public IEnumerable<FootballPlayer> Get()
        {
            return _context.FootballPlayers.ToList();
        }

        public bool Create(FootballPlayer value)
        {
            try
            {
                value.Id = 0;
                _context.FootballPlayers.Add(value);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
