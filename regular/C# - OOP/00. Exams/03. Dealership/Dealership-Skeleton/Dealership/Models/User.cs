using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models
{
    public class User : IUser
    {
        // Fields
        private string userName;
        private string firstName;
        private string lastName;
        private string password;

        // Constructors
        public User(string userName, string firstname, string lastName, string password, Role role)
        {
            this.Username = userName;
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Password = password;
            this.Role = role;
        }

        // Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validator.ValidateNull(value, "first name can not be null");
                Validator.ValidateIntRange(value.Length,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax,
                    nameof(this.FirstName),
                    Constants.MinNameLength,
                    Constants.MaxNameLength));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validator.ValidateNull(value, "last name can not be null");
                Validator.ValidateIntRange(value.Length,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax,
                    nameof(this.LastName),
                    Constants.MinNameLength,
                    Constants.MaxNameLength));

                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            private set
            {
                Validator.ValidateNull(value, "first name can not be null");
                Validator.ValidateSymbols(value, Constants.PasswordPattern,
                     string.Format(Constants.InvalidSymbols, nameof(this.Password)));

                this.password = value;
            }
        }

        public Role Role
        {
            get; private set;
        }

        public string Username
        {
            get
            {
                return this.userName;
            }

            private set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                Validator.ValidateSymbols(value, Constants.UsernamePattern,
                    string.Format(Constants.InvalidSymbols, nameof(this.Username)));

                this.userName = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get; private set;
        }

        // Methods
        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            throw new NotImplementedException();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
