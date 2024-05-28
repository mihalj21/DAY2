using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.DeletePlayerService
{
    internal class DeletePlayer
    {
        public DeletePlayer() { }


        public void DeletePlayerByIndex(List<FootballPlayer> players, int index)
        {
            if (index >= 0 && index < players.Count)
            {
                players.RemoveAt(index);
                Console.WriteLine($"Player at index {index} has been successfully deleted.");
            }
            else
            {
                Console.WriteLine($"Invalid index: {index}. Player not deleted.");
            }
        }
    }
}
