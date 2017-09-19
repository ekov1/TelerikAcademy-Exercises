using OlympicGames.Olympics.Enums;
using OlympicGames.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Models
{
    public class Boxer : Olympian
    {
        private int wins;
        private int losses;

        public Boxer(string firstName, string lastName, string country, BoxingCategory category,
            int wins, int losses)
            : base(firstName, lastName, country)
        {
            this.Category = category;
            this.Wins = wins;
            this.losses = losses;
        }

        public BoxingCategory Category { get; private set; }

        public int Wins
        {
            get
            {
                return this.wins;
            }

            set
            {
                Validator.ValidateIfNull(value, "wins can not be null");
                Validator.ValidateMinAndMaxNumber(value, 0, 100, "wins must be a number between 0 and 100");
                this.wins = value;
            }
        }

        public int Losses
        {
            get
            {
                return this.losses;
            }

            set
            {
                Validator.ValidateIfNull(value, "wins can not be null");
                Validator.ValidateMinAndMaxNumber(value, 0, 100, "wins must be a number between 0 and 100");
                this.losses = value;
            }
        }
    }
}
