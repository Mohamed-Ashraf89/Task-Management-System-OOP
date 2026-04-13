using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    abstract class BaseTask
    {
            public string Title { get; set; }

            public string Description { get; set; }

            public bool IsComplete { get; set; }

            public abstract void GetTaskType();

            public void MarkAsDone()
            {
                IsComplete = true;
                Console.WriteLine($"The {Title} now is done");
            }
        
    }
}
