using System;

namespace Tasker.Core.Contracts
{
    public interface ITask
    {
        int Id { get; set; }

        string Description { get; set; }

        bool IsDone { get; set; }

        DateTime? deadline { get; set; }
    }
}
