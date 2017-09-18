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
            var list = new List();

            // Act
            manager.Add(taskStub.Object);
            // Assert
        }
    }
}
