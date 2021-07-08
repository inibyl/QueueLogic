using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace QueueLogic
{
    public class TaskQueue
    {
        private Queue<Task> Countainer = new Queue<Task>();
        private Task MainTask = new Task(RunQueue);

        public QueueLogic()
        {
            MainTask.Start();
        }

        public void AddToQueue(Task task)
        {
            Countainer.Enqueue(task);
        }

        private void RunQueue()
        {
            while (true)
            {
                Thread.Sleep(5);
                
                if (Countainer.Count > 0)
                {
                    try
                    {
                        Countainer.Peek().Start();
                    }
                    catch (Exception e) { Console.WriteLine(e); }
                    
                    try
                    {
                        Countainer.Dequeue().Wait();
                    }
                    catch (Exception e) { Console.WriteLine(e); }
                }
                
                Thread.Sleep(5);
            }
        }
    }
}
