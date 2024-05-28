using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    public class FootballPlayer: Person

    {
        public FootballPlayer() { }
        public FootballPlayer(string firstname, string lastname) { 
            FirstName = firstname;
            LastName = lastname;
        }
        public int Age { get; set; }
        
        public Club Club { get; set; }

        public  string PlayerInfo()
        {
            return $"Football player: {this.FirstName} {this.LastName} {this.Age} {this.Club.Name} {this.Club.Country} {this.Club.League}";
        }

    }
}
