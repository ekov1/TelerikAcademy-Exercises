using Traveller.Models.Enums;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        VehicleType Type { get; }
        int PassangerCapacity { get; }
        decimal PricePerKilometer { get; }
    }
}