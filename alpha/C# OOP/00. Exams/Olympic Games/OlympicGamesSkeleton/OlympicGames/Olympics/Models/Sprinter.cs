using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Models
{
    public class Sprinter : Olympian
    {
        public Sprinter(string firstName, string lastName, string country)
            : base(firstName, lastName, country)
        {
            this.PersonalRecords = new List<KeyValuePair<string, double>>();
        }

        public IList<KeyValuePair<string, double>> PersonalRecords { get; set; }
    }
}
