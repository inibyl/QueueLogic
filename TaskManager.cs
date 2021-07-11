using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskManager
    {
        private Task MainTask;
        private List<Task> Countainer;
        
        public TaskManager()
        {
            Countainer = new List<Task>();
            MainTask = new Task(StartManager);
            MainTask.Start();
        }

        public void AddToManager(Task task)
        {
            Countainer.Add(task);
        }

        private void StartManager()
        {
            while (true)
            {
                Thread.Sleep(5);

                if (Countainer.Count > 0)
                {
                    Countainer[0].Start();
                    Countainer.RemoveAt(0);
                }
                
                Thread.Sleep(5);
            }
        }
    }
}
