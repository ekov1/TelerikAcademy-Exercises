using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;

namespace OlympicGames.Models
{
    public abstract class Olympian : IOlympian
    {
        private string firstName;
        private string lasttName;
        private string country;

        public Olympian(string firstName, string lastName, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.country = country;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                Validator.ValidateIfNull(value, "FirstName must not be null");
                Validator.ValidateMinAndMaxLength(value, 2, 20, "FirstName must be in the interval of [2,20] symbols");
                //if (value == null || value.Length < 2 || value.Length > 20)
                //{
                //    throw new ArgumentException("FirstName must be in the interval of [2,20] symbols");
                //}
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lasttName;
            }

            set
            {
                Validator.ValidateIfNull(value, "LastName must not be null");
                Validator.ValidateMinAndMaxLength(value, 2, 20, "LastName must be in the interval of [2,20] symbols");
                //if (value == null || value.Length < 2 || value.Length > 20)
                //{
                //    throw new ArgumentException("LastName must be in the interval of [2,20] symbols");
                //}
                this.LastName = value;
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                Validator.ValidateIfNull(value, "Country must not be null");
                Validator.ValidateMinAndMaxLength(value, 3, 25, "Country must be in the interval of[3, 25] symbols");
                //if (value == null || value.Length < 3 || value.Length > 25)
                //{
                //    throw new ArgumentException("Country must be in the interval of [3,25] symbols");
                //}
                this.country = value;
            }
        }
    }
}
