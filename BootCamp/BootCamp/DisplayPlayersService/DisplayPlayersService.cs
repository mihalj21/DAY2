using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp;

namespace BootCamp.DisplayPlayersService
{
    internal class DisplayService
    {
        public DisplayService() { }

        public static void DisplayPlayers(List<FootballPlayer> players)
        {
            Console.WriteLine("\nPlayers Information:");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"Index: {i}, {players[i].PlayerInfo()}");
            }
        }
    }
}
