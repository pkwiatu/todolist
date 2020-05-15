using System;
using System.Collections.Generic;
using System.Text;

namespace todolist
{
    class AddTask
    {
        public void AddNewTask(ref string[] listTasks)
        {
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                Array.Resize(ref listTasks, listTasks.Length + count);
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Name of task: ");
                    string task = Console.ReadLine();
                    listTasks[i] = task;
                }
                Console.WriteLine($"You just added {count} tasks.");
                Console.WriteLine();
            }
        }
    }
}
