using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Factories;
using Traveller.Core.Providers;

namespace Traveller.Tests.Commands.Core.Providers.CommandParserTests
{
    [TestFixture]
    class ParseCommandShould
    {

        [Test]
        public void ReturnInstance_WhenArgumentsAreValid()
        {
            // Arrange
            var factoryStub = new Mock<ICommandFactory>();
            var CommandParserStub = new Mock<IParser>();
            // Act 
            var train = CommandParserStub.Object.ParseCommand("createtrain");

            // Assert
            Assert.IsNotNull(train);
        }

        [Test]
        public void ParserShouldReturnCorrectParameters()
        {
            var factoryStub = new Mock<ICommandFactory>();
            var parser = new CommandParser(factoryStub.Object);

            //factoryStub.Setup.

            ICollection<string> paramsList = parser.ParseParameters("createtrain");

            CollectionAssert.Contains(paramsList, "train");
        }
    }
}
