using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.ChoosePlayerService
{
    internal class ChoosePlayer
    {
        public ChoosePlayer() { }

        public FootballPlayer Choose(List<FootballPlayer> players)
        {
           
            
            Console.WriteLine("\nEnter the index of the player you want to edit (or enter -1 to cancel):");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Please enter a valid index or -1 to cancel:");
            }

            if (index >= 0 && index < players.Count)
            {
                return players[index];
            }
            else
            {
                return null;
            }
        }
    }
}
