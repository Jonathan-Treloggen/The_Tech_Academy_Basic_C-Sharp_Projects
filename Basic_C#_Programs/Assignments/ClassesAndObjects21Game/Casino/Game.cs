using System;
using System.Collections.Generic;

namespace Casino
{
    public abstract class Game
    {
        // MAKES AN EMPTY LIST INSTEAD OF IT BEING NULL
        private List<Player> _player = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _player; } set { _player = value; } }

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

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
