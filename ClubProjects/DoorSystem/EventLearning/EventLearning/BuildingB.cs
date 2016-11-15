using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLearning
{
    public class BuildingB
    {
        public BuildingB()
        {
            HandleB = new Handle();
            HandleB.HandleOpened += HandlerB_HandleOpened;
        }

        private void HandlerB_HandleOpened(object sender, HandleOpenTimeEventArg e)
        {
            System.Console.WriteLine("BuildingB's Door opened at: "+e.OpenTime);
            Console.ReadKey();
        }

        public Handle HandleB { get;}
    }
}
