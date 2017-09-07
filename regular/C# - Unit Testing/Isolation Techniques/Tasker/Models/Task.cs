using System;

namespace Tasker.Models
{
    public class Task
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
