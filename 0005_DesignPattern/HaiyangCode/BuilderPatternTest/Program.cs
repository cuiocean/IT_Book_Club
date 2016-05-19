using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // Lets create the Director first
            Manufacturer newManufacturer = new Manufacturer();
            // Lets have the Builder class ready
            IStaticModelBuilder staticModelBuilder = null;

            // Now let us create an Pillar grid model 
            staticModelBuilder = new PillarGridModelBuilder();
            newManufacturer.Construct(staticModelBuilder);
            Console.WriteLine("A new Static Model built:\n\n{0}\n", staticModelBuilder.StaticModel.ToString());

            // Now let us create a CornerPoint grid model
            staticModelBuilder = new CornerPointGridModelBuilder();
            newManufacturer.Construct(staticModelBuilder);
            Console.WriteLine("A new Static Model built:\n\n{0}\n", staticModelBuilder.StaticModel.ToString());

        }
    }
}
