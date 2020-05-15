using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    public class ToDoList
    {
        public List<string> tasks = new List<string>();
        public void AddTask()
        {
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Name of task: ");
                    string newTask = Console.ReadLine();
                    tasks.Add(newTask);
                }
                Console.WriteLine($"You just added {count} tasks.");
                Console.WriteLine();
            }
        }
        public void RemoveTask(int option)
        {
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Remove by number");
                    if (int.TryParse(Console.ReadLine(), out int delTask))
                    {
                        string tempTitle = tasks[delTask - 1];
                        tasks.RemoveAt(delTask - 1);
                        Console.WriteLine($"You just remove '{tempTitle}'");
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Remove by title");
                    string title = Console.ReadLine();
                    tasks.Remove(title);
                    break;
                default:
                    break;
            }
        }
        public void DisplayTasks()
        {
            Console.Clear();
            var j = 1;
            foreach (var item in tasks)
            {
                Console.WriteLine($"[{j++}]. {item}");
            }
            Console.WriteLine();
        }
        public void Menu()
        {
            Console.WriteLine("1. Add new task");
            Console.WriteLine("2. Remove task");
            Console.WriteLine("3. Display task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");
        }
    }
}
