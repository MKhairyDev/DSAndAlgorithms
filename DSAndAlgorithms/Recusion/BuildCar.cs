
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    public class BuildCar
    {
        public static void Build(List<CarTask> carTasksList)
        {
            //O(n) complexity
            foreach (var task in carTasksList)
            {
                task.BuildTask();
            }
        }

    }



    public class CarTask
    {
        string _taskName;
        public bool IsBuildDone { get; set; }
        public CarTask(string taskName, List<CarTask> dependencyList)
        {
            _taskName = taskName;
            DependencyList = dependencyList;
        }
        public List<CarTask> DependencyList;
        public void BuildTask()
        {
            if (IsBuildDone)
                return;
            foreach (var task in DependencyList)
            {
                if (!task.IsBuildDone)
                    task.BuildTask();
            }
            Run();
        }
        public void Run()
        {
            IsBuildDone = true;
            Console.WriteLine("Completed Task : " + _taskName);
        }

    }
}
