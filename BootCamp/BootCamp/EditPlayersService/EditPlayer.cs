using BootCamp.DisplayPlayersService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.EditPlayersService
{
    internal class EditPlayer
    {
        public EditPlayer() { }


        public  void Edit(FootballPlayer player) {

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Edit Name");
            Console.WriteLine("2. Edit LastName");
            Console.WriteLine("3. Edit Club");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                

                switch (choice)
                {
                    case 1:
                        player.FirstName = Prompt("Enter new first name:");
                        break;
                    case 2:
                        player.LastName = Prompt("Enter new last name:");
                        break;
                    case 3:
                        Club newClub = new Club();
                        newClub.Name = Prompt("Enter new club name:");
                        newClub.Country = Prompt("Enter new club country:");
                        newClub.League = Prompt("Enter new club league:");
                        player.Club = newClub;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
            }

         string Prompt(string message)
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            }

             int PromptForInteger(string message)
            {
                int result;
                while (!int.TryParse(Prompt(message), out result))
                {
                    Console.WriteLine("Please enter a valid integer:");
                }
                return result;
            }
        }
       

    }
}
