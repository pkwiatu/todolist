using System;
using System.Collections.Generic;
using System.Text;

namespace todolist
{
    public class DisplayTasks
    {
        public void Display(ref string[] listTasks)
        {
            var j = 1;
            foreach (var task in listTasks)
            {
                Console.WriteLine($"[{j++}]. {task}");
            }
        }
    }
}
