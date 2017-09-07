using Tasker.Core;
using Tasker.Models;

namespace Tasker
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var manger = new TaskManager();
            var task = new Task("Some task");

            manger.Add(task);
        }
    }
}
