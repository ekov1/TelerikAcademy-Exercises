using System;
using Tasker.Core.Contracts;

namespace Tasker.Models
{
    public class Task : ITask
    {
        // Constructors
        public Task(string description)
        {
            this.Description = description;
            this.IsDone = false;
        }

        // Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime? deadline { get; set; }
    }
}
