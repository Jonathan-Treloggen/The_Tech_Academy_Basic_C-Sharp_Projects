using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects21Game
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        // ABSTRACT METHOD MUST BE PUT IN THE INHERITANCE CLASS AND DEFINED THEIR AS WELL
        public abstract void Play();

        // VIRTUAL ALLOW YOU TO OVERRIDE AND CUSTOMIZE METHOD ALREADY DEFINED IN ABSTRACT CLASS IN OTHER CLASS
        public virtual void ListPlayer()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
