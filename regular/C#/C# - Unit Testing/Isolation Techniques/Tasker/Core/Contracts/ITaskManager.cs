namespace Tasker.Core.Contracts
{
    public interface ITaskManager
    {
        void Add(ITask task);

        void Remove(int id);
    }
}
