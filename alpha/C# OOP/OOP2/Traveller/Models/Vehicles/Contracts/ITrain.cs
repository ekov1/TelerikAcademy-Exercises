using Traveller.Enums;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface ITrain : IVehicle
    {
        int Carts { get; }
    }
}