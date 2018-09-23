using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternTest
{
    class StaticModel
    {
        string    _staticModelName;

        public StaticModel(string name)
        {
            _staticModelName = name;
            GridType = GridType.UNDEFINED;
            NumFaults = 0;
            NumZones = 0;
        }

        public string StaticModelName
        {
            get { return _staticModelName; }
        }

        public GridType GridType { get; set; }
        public int NumFaults {get; set; }
        public int NumZones { get; set; }

        // Methiod to display details 
        public override string ToString()
        {
            return string.Format("Name: {0}\nGridType: {1}\nNumFaults {2}\nNumZones: {3}\n",
                _staticModelName, GridType, NumFaults, NumZones);
        }
    }
}
