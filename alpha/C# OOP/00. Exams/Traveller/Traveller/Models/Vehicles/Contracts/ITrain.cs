namespace Traveller.Models.Vehicles.Contracts
{
    public interface ITrain : IVehicle
    {
        // Please, please, please implement me
        VehicleType Type { get; set; }

        int Carts { get; }
    }
}