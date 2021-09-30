using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootBallLib;

namespace Opgave4RestService.Managers
{
    public class FootballPlayerManager
    {
        private static int _nextId = 1;

        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer(1, "e", 2323, 2323)
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(footballPlayer => footballPlayer.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newFP)
        {
            newFP.Id = _nextId++;
            Data.Add(newFP);
            return newFP;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer FP = Data.Find(footballPlayer1 => footballPlayer1.Id == id);
            if (FP == null) return null;
            Data.Remove(FP);
            return FP;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer FP1 = Data.Find(footballPlayer1 => footballPlayer1.Id == id);
            if (FP1 == null) return null;
            FP1.Name = updates.Name;
            FP1.Price = updates.Price;
            return FP1;
        }
    }
}
