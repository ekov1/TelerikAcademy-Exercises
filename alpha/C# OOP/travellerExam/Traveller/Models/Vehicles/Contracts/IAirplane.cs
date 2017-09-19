﻿namespace Traveller.Models.Vehicles.Contracts
{
    public interface IAirplane
    {
        int PassangerCapacity { get; }

        decimal PricePerKilometer { get; }

        bool HasFreeFood { get; }
    }
}