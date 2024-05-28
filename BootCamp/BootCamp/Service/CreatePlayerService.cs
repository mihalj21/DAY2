using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Service
{
    internal class CreatePlayerService
    {
        public CreatePlayerService() { }

        public static FootballPlayer CreatePlayer()
        {
            FootballPlayer player = new FootballPlayer();
            player.FirstName = Prompt("Enter FootballPlayer Name: ");
            player.LastName = Prompt("Enter FootballPlayer LastName: ");
            player.Age = int.Parse(Prompt("Enter FootballPlayer Age: "));

            Club footballClub = new Club();
            footballClub.Name = Prompt("Enter FootballClub Name: ");
            footballClub.Country = Prompt("Enter FootballClub Country: ");
            footballClub.League = Prompt("Enter FootballClub League: ");

            player.Club = footballClub;

            return player;
        }

        static string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
