using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildingA OneBuildingA = new BuildingA();
            BuildingB OneBuildingB = new BuildingB();

            OneBuildingA.HandlerA.Open();
            OneBuildingB.HandlerB.Open();
        }
    }
}
