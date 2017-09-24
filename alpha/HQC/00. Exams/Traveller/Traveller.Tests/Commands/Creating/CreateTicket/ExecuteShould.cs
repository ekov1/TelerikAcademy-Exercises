using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Traveller.Commands.Creating;
using Traveller.Core.Contracts;
using Traveller.Models.Abstractions;

namespace Traveller.Tests.Commands.Creating.CreateTicket
{
    [TestFixture]
    class ExecuteShould
    {
        [Test]
        public void ExecuteShould_ReturnSuccessfulMessageWhenTicketIsCreated()
        {
            // Arange
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<ITravellerFactory>();
            var journeyStub = new Mock<IJourney>();
            
            databaseStub.Object.Journeys.Add(journeyStub.Object);

            var parameters = new List<string>();
            parameters.Add("0");
            parameters.Add("30");

            // Act 
            var createTicketCommand =
                new CreateTicketCommand(databaseStub.Object, factoryStub.Object);
            var msg = createTicketCommand.Execute(parameters);

            //Assert
            StringAssert.Contains("created", msg);
        }

        [Test]
        public void ExecuteShould_ReturnsErrorOnUnsuccessfulParse()
        {
            // Arange
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<ITravellerFactory>();

            var parameters = new List<string>();
            parameters.Add("0");
            parameters.Add("30");
            var createTicketCommand =
                new CreateTicketCommand(databaseStub.Object, factoryStub.Object);
            //Assert
            Assert.Throws(typeof(ArgumentException), () =>
            {
                var msg = createTicketCommand.Execute(parameters);
            });
        }
    }
}
