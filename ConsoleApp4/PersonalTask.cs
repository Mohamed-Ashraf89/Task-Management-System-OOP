using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class PersonalTask : BaseTask
    {
        public string PlaceTask { get; set; }

        public override void GetTaskType()
        {
            Console.WriteLine("This is a personal task");
        }
    }
}
