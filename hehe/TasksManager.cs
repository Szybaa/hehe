using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hehe
{
    class TasksManager
    {
        private List<ITask> waitingTasks = new List<ITask>();
        private List<ITask> finishedTasks = new List<ITask>();
        
        public delegate string TaskAdd();
        public delegate string TaskFinish();

        public event TaskAdd TaskAddEvent;
        public event TaskFinish TaskFinishEvent;

        protected virtual void TaskAddVoid(string name)
        {
            if (TaskAddEvent != null)
            {
                TaskAddEvent();
            }
            else
            {
                Console.WriteLine($"task added:{name}");
            }
        }

        private void TaskFinishVoid(string name)
        {
            if (TaskFinishEvent != null)
            {
                TaskFinishEvent();
            }
            else
            {
                Console.WriteLine($"task finished:{name}");
            }
        }

        public void AddTask(ITask task)
        {
            waitingTasks.Add(task);
            TaskAddVoid(task.Name);
        }
        public void FinishTask(int index)
        {
            /*
            var d = waitingTasks[index];
            finishedTasks.Add(d);
            waitingTasks.RemoveAt(index);
            */
            var d = waitingTasks[index];
            finishedTasks.Add(waitingTasks.ElementAt(index));
            waitingTasks.RemoveAt(index);
            TaskFinishVoid(d.Name);

        }
        public override string ToString()
        {
            int i = 1;
            Console.WriteLine($"Waiting:\n");
            foreach (var w in waitingTasks)
            {
                Console.WriteLine("- " + i +$" {w}");
                i++;
            }
            Console.WriteLine($"Finished:\n");
            int o = 1;
            foreach (var f in finishedTasks)
            {
                Console.WriteLine("+ "+o + $": {f}");
                o++;
            }


            return "";
        }

    }
}
