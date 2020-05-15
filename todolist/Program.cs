using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            var todolist = new ToDoList();
            var exit = false;

            do
            {
                todolist.Menu();
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Number of new task: ");
                            todolist.AddTask();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("[1]Remove by number");
                            Console.WriteLine("[2]Remove by title");
                            Console.Write("Choose your option: ");
                            if (int.TryParse(Console.ReadLine(),out int removeOption))
                            {
                                todolist.RemoveTask(removeOption);
                            }
                            break;
                        case 3:
                            todolist.DisplayTasks();
                            break;
                        default:
                            exit = true;
                            break;
                    }
                }
            } while (!exit);
        }
    }
}
