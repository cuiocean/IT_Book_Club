using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLearning
{
    public class BuildingA
    {
        public BuildingA()
        {
            HandleA = new Handle();
            HandleA.HandleOpened += HandlerA_HandleOpened;
        }

        private void HandlerA_HandleOpened(object sender, HandleOpenTimeEventArg e)
        {
            System.Console.WriteLine("BuildingA's Door opened at: "+e.OpenTime);
            Console.ReadKey();
        }

        public Handle HandleA { get; }
    }
}
