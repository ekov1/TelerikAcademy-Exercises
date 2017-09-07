using System;
using System.Collections.Generic;
using System.Linq;
using Tasker.Core.Providers;
using Tasker.Models;

namespace Tasker.Core
{
    public class TaskManager
    {
        // private IList<Task> tasks;
        private ICollection<Task> tasks;
        private IdProvider idProvider;
        public TaskManager()
        {
            this.tasks = new List<Task>();
            this.idProvider = new IdProvider();
        }
        public void Add(Task task)
        {

            if (task == null)
            {
                throw new ArgumentNullException();
            }

            task.Id = this.idProvider.NextId();
            this.tasks.Add(task);
            Console.WriteLine("A new task was added!");
        }

        public void Remove(int id)
        {
            // this.tasks.RemoveAt(id); // List
            var task = this.tasks.SingleOrDefault(x => x.Id == id);

            if (task == null)
            {
                Console.WriteLine($"The task with ID {id} was not found!");
            }
            else
            {
                this.tasks.Remove(task);
                Console.WriteLine($"The task with ID {id} was removed!");
            }
        }
    }
}
