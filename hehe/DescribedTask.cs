using System;
using System.Collections.Generic;
using System.Text;

namespace hehe
{
    class DescribedTask:PriorityTask
    {
        public string Description
        {
            get;
            set;
        }
        public DescribedTask()
        {
            this.Priority = 0;
        }
        public DescribedTask(string name, int priority, string description)
        {
            this.Name = name;
            this.Priority = priority;
            this.Description = description;
        }
        public DescribedTask(DescribedTask task)
        {
            this.Name = task.Name;
            this.Priority = task.Priority;
            this.Description = task.Description;
        }
        public override string ToString()
        {
            return "{" + $"Name: {Name}; Priority: {Priority}; Description: {Description}" + "}";
        }
    }
}
