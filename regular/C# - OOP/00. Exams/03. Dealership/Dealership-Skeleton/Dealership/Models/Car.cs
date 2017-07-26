using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        public int Seats
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Car;
            }
        }
    }
}
