using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Models;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand
    {
        // Consider using the dictionary
        private readonly IDictionary<string, double> records;

        public Sprinter CreateSprinter(string firstName, string lastName, string country)
        {
            return new Sprinter(firstName, lastName, country);
        }
    }
}
