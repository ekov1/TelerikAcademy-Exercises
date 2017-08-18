using System;
using Traveller.Enums;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        int PassangerCapacity { get; }

        VehicleType Type { get; }

        decimal PricePerKilometer { get; }
    }
}