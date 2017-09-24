using System;
using System.Collections.Generic;
using System.Linq;
using Tasker.Core.Contracts;
using Tasker.Core.Providers;
using Tasker.Models;

namespace Tasker.Core
{
    public class TaskManager : ITaskManager
    {
        // Fields
        // private IList<Task> tasks;
        private readonly ICollection<ITask> tasks;
        private readonly IIdProvider idProvider;
        private readonly ILogger logger;

        // Constructors
        public TaskManager(IIdProvider idProvider, ILogger logger)
        {
            this.tasks = new List<ITask>();
            this.idProvider = idProvider;
            this.logger = logger;
        }

        // Methods
        public void Add(ITask task)
        {

            if (task == null)
            {
                throw new ArgumentNullException();
            }

            task.Id = this.idProvider.NextId();
            this.tasks.Add(task);
            this.logger.Log("A new task was added!");
        }

        public void Remove(int id)
        {
            // this.tasks.RemoveAt(id); // List
            var task = this.tasks.SingleOrDefault(x => x.Id == id);

            if (task == null)
            {
               this.logger.Log($"The task with ID {id} was not found!");
            }
            else
            {
                this.tasks.Remove(task);
                this.logger.Log($"The task with ID {id} was removed!");
            }
        }
    }
}
