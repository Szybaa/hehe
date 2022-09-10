using System;
using System.Collections.Generic;
using System.Text;

namespace hehe
{
    class PriorityTask:ITask
    {
        public string Name
        {
            get;
            set;
        }
        public int Priority
        {
            get;
            set;
        }
        public PriorityTask()
        {
            this.Name = "Empty";
            this.Priority = 0;
        }
        public PriorityTask(string name, int priority)
        {
            this.Name = name;
            this.Priority = priority;       
        }
        public PriorityTask(PriorityTask task)
        {
            this.Name = task.Name;
            this.Priority = task.Priority;
        }
        public override string ToString()
        {
            return"{"+$"Name: {Name}; Priority: {Priority}"+"}";
        }
    }
}
