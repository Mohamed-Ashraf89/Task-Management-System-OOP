using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TaskManager
{

    class Program
    {
        static void Main(string[] args)
        {
            //Create list for tasks

            List<BaseTask> myTasks = new List<BaseTask>();
            WorkTask work1 = new WorkTask { Title = "Fix login bug", ProjectName = "E-Commerc App" };

            PersonalTask work2 = new PersonalTask { Title = "Buy Milk", PlaceTask = "Supermarket" };

            myTasks.Add(work1);
            myTasks.Add(work2);

            //Make statue for worktask is done

            work1.IsComplete = true;

            //Print the tasks whoes is finished
            foreach (var task in myTasks)
            {
                if (task.IsComplete)
                {
                    Console.WriteLine($"The task is finished is [{task.Title}]");
                    task.GetTaskType();


                    if (task is IPriority PriorityTask)
                    {
                        PriorityTask.SetPriority("High");
                    }

                    Console.WriteLine("---------------------------");
                }
            }

            Console.ReadKey();

        }

    }


}