using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.AddPlayersService
{
    internal class AddPlayer
    {
        public AddPlayer() { }

        public void Add(List<FootballPlayer> players, FootballPlayer newPlayer)
        {
            players.Add(newPlayer);
        }

    }
}
