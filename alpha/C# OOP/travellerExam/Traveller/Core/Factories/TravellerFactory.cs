using System;
using Traveller.Core.Contracts;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Core.Factories
{
    public class TravellerFactory : ITravellerFactory
    {
        private static ITravellerFactory instanceHolder = new TravellerFactory();

        private TravellerFactory()
        {
        }

        public static ITravellerFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }
        
        public IBus CreateBus(int passengerCapacity, decimal pricePerKilometer)
        {
            throw new NotImplementedException("You are invoking a TravellerFactory method that is not yet implemented!");
        }

        public IAirplane CreateAirplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood)
        {
            throw new NotImplementedException("You are invoking a TravellerFactory method that is not yet implemented!");
        }

        public ITrain CreateTrain(int passengerCapacity, decimal pricePerKilometer, int carts)
        {
            throw new NotImplementedException("You are invoking a TravellerFactory method that is not yet implemented!");
        }
        
        public IJourney CreateJourney(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            throw new NotImplementedException("You are invoking a TravellerFactory method that is not yet implemented!");
        }

        public ITicket CreateTicket(IJourney journey, decimal administrativeCosts)
        {
            throw new NotImplementedException("You are invoking a TravellerFactory method that is not yet implemented!");
        }
    }
}
