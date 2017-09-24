using Moq;
using NUnit.Framework;
using Traveller.Commands.Creating;
using Traveller.Core.Contracts;

namespace Traveller.Tests.Commands.Creating.CreateTicket
{
    [TestFixture]
    public class ConstructorShould
    {
        [Test]
        public void ConstructorShould_CorrectlyAssignDatabase()
        {
            // Arrange
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<ITravellerFactory>();

            // Act 
            var createTicketCommand = new CreateTicketCommand(databaseStub.Object, factoryStub.Object);

            // Assert
            Assert.AreSame(databaseStub.Object, createTicketCommand.Database);
        }

        [Test]
        public void ConstructorShould_CorrectlyAssignFactory()
        {
            // Arrange
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<ITravellerFactory>();

            // Act 
            var createTicketCommand = new CreateTicketCommand(databaseStub.Object, factoryStub.Object);

            // Assert
            Assert.AreSame(factoryStub.Object, createTicketCommand.Factory);
        }

        [Test]
        public void ReturnInstance_WhenArgumentsAreValid()
        {
            // Arrange
            var databaseStub = new Mock<IDatabase>();
            var factoryStub = new Mock<ITravellerFactory>();

            // Act 
            var createTicketCommand = new CreateTicketCommand(databaseStub.Object, factoryStub.Object);

            // Assert
            Assert.IsNotNull(createTicketCommand);
        }
    }
}
