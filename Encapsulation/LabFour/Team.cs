using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabOne;

namespace LabFour
{
    class Team
    {
        private string name;
        private List<Person> fistTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            
            this.fistTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            this.name = name;
        }

        public List<Person> FistTeam { get { return this.fistTeam; }}
        public List<Person> ReserveTeam { get { return this.reserveTeam; } }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
                fistTeam.Add(player);
            else
                reserveTeam.Add(player);
        }

        public override string ToString()
        {
            return $"First Team has {fistTeam.Count} players \nReserve Team has {reserveTeam.Count} players";

        }
    }
}
