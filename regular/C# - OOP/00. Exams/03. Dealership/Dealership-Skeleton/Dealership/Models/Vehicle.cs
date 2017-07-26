using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    class Vehicle : IVehicle
    {
        public IList<IComment> Comments
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Make
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Model
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public VehicleType Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Wheels
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
