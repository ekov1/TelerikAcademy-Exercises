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
            this.Vehicles = new List<IVehicle>();
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
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            bool isAdmin = this.Role == Role.Admin;
            bool canAddMoreVehicles = this.Role == Role.VIP || this.Vehicles.Count == 5;

            if (isAdmin || !canAddMoreVehicles)
            {
                return;
            }
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove.Author == this.Username
                && vehicleToRemoveComment.Comments.Contains(commentToRemove))
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            if (this.Vehicles.Contains(vehicle))
            {
                this.Vehicles.Remove(vehicle);
            }
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();
        }
    }
}
