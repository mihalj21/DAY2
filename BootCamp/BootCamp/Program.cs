using BootCamp.AddPlayersService;
using BootCamp.ChoosePlayerService;
using BootCamp.DeletePlayerService;
using BootCamp.DisplayPlayersService;
using BootCamp.EditPlayersService;
using BootCamp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            ChoosePlayer choosePlayer = new ChoosePlayer();
            EditPlayer  editPlayer = new EditPlayer();
            DeletePlayer deletePlayer = new DeletePlayer();
            AddPlayer addPlayer = new AddPlayer();
            List<FootballPlayer> players = new List<FootballPlayer>();
            Console.WriteLine("Unesi broj igraca:");

            int numPlayers;
            while (!int.TryParse(Console.ReadLine(), out numPlayers) || numPlayers <= 0)
            {
                Console.WriteLine("Unesi broj igrača većih od 0:");
            }

            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine($"Player {i + 1}:");
                FootballPlayer player = CreatePlayerService.CreatePlayer();
                players.Add(player);
            }


            bool exit = false;

            while (!exit) {

                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. View Players");
                Console.WriteLine("2. Edit Player");
                Console.WriteLine("3. Add Player");
                Console.WriteLine("4. Delete Player");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                           
                            DisplayService.DisplayPlayers(players);
                            break;
                        case 2:
            
                            FootballPlayer playerToEdit = choosePlayer.Choose(players);
                            editPlayer.Edit(playerToEdit);  
                            break;
                        case 3:
                            FootballPlayer newPlayer = CreatePlayerService.CreatePlayer();
                            addPlayer.Add(players, newPlayer);
                            break;
                        case 4:
                            Console.Write("Index player-a kojeg zelis obrisati");
                            int index = int.Parse(Console.ReadLine());
                            deletePlayer.DeletePlayerByIndex(players, index);
                            break;
                        case 5:
                            exit = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Greška, molim te unesi ispravan broj:");
                }
            }

            Console.WriteLine("\nPlayers Information:");


            foreach (FootballPlayer player in players)
            {
                Console.WriteLine(player.PlayerInfo());
            }

            
            
           /* Console.WriteLine("Enter FootballPlayer Name: ");
            player.FirstName = Console.ReadLine();

          
            Console.WriteLine("Enter FootballPlayer lastName: ");
            player.LastName = Console.ReadLine();

            Console.WriteLine("Enter FootballPlayer age: ");
            player.Age = int.Parse(Console.ReadLine());

            Club FootballClub = new Club();
            Console.WriteLine("Enter FootBallClub Name: ");
            FootballClub.Name = Console.ReadLine();
            Console.WriteLine("Enter FootballClub Country: ");
            FootballClub.Country = Console.ReadLine();
            Console.WriteLine("Enter FootballClub League : ");
            FootballClub.League = Console.ReadLine();

            player.Club = FootballClub;
            

            Console.WriteLine(player.PlayerInfo());
           */

            
        }
    }
}
