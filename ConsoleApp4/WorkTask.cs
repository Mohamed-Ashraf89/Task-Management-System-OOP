using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class WorkTask : BaseTask, IPriority
    {
        public string ProjectName { get; set; }

        public override void GetTaskType()
        {
            Console.WriteLine("This is a professional work task");
        }

        public void SetPriority(string Level)
        {
            Console.WriteLine($"Priority set to [{Level}] , for projevt [{ProjectName}]");
        }
    }
}
