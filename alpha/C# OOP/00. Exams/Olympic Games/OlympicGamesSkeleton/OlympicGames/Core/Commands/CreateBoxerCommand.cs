using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using OlympicGames.Models;
using OlympicGames.Olympics.Enums;

namespace OlympicGames.Core.Commands
{
    public class CreateBoxerCommand
    {
        public Boxer CreateBoxer(string firstName, string lastName, string country, BoxingCategory category,
            int wins, int losses)
        {
            return new Boxer(firstName, lastName, country, category, wins, losses);
        }
    }
}
