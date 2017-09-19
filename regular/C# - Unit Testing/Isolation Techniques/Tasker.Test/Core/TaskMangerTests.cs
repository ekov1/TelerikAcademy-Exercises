using Moq;
using NUnit.Framework;
using Tasker.Core;
using Tasker.Core.Contracts;

namespace Tasker.Test.Core
{
    [TestFixture]
    public class TaskMangerTests
    {
        [Test]
        public void Add_ShouldLogSuccessfulMessage_WhenPassedValidTask()
        {
            // Arange
            var idProviderStub = new Mock<IIdProvider>();
            var loggerMock = new Mock<ILogger>();
            var taskStub = new Mock<ITask>();

            var manager = new TaskManager(idProviderStub.Object, loggerMock.Object);

            // Act
            manager.Add(taskStub.Object);

            // Assert
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Add_ShouldCorrectlyAssigntaskIds_WhenValidTaskIsProvided()
        {
            // Arange
            var idProviderStub = new Mock<IIdProvider>();
            var loggerStub = new Mock<ILogger>();
            var taskMock = new Mock<ITask>();

            idProviderStub.Setup(x => x.NextId()).Returns(0);
            var manager = new TaskManager(idProviderStub.Object, loggerStub.Object);

            // Act
            manager.Add(taskStub.Object);

            // Assert
            loggerMock.Verify(x => x.Log(It.IsAny<string>()), Times.Once);
        }
    }
}
