using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternTest
{
    class Manufacturer
    {
        public void Construct(IStaticModelBuilder staticModelBuilder)
        {
            staticModelBuilder.BuildGrid();
            staticModelBuilder.BuildFaults();
            staticModelBuilder.BuildZones();
        }
    }
}
