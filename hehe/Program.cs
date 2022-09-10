using System;

namespace hehe
{
    class Program
    {
        static void Main(string[] args)
        {
            DescribedTask baseTask = new DescribedTask("Base task", 3, "Base task description");

            TasksManager tasksManager = new TasksManager();

            tasksManager.AddTask(new PriorityTask());
            tasksManager.AddTask(new PriorityTask("Task 1", 1));
            tasksManager.AddTask(new DescribedTask("Task 2", 2, "Description 2"));
            tasksManager.AddTask(new DescribedTask("Task 3", 2, "Description 3"));
            tasksManager.AddTask(new PriorityTask(baseTask));
            tasksManager.AddTask(new DescribedTask(baseTask));

            Console.WriteLine(tasksManager);

            Console.WriteLine("-----------------------------------");

            tasksManager.FinishTask(1);
            tasksManager.FinishTask(0);

            Console.WriteLine(tasksManager);
        }
    }
}
