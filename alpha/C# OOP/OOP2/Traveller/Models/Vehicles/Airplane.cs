using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        // Fields
        private int passangerCapacity;

        // Constructors

        // Properties
        public bool HasFreeFood
        {
            get; private set;
        }

        public override int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }

            set
            {
                ValidatePassangerCapacity(value);

                this.passangerCapacity = value;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Air;
            }
        }
    }
}
