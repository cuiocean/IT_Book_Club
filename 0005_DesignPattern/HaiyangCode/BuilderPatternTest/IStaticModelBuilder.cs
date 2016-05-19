using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternTest
{
    interface IStaticModelBuilder
    {
        void BuildGrid();
        void BuildFaults();
        void BuildZones();
        StaticModel StaticModel { get; }
    }
}
