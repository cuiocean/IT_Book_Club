using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternTest
{
    class PillarGridModelBuilder: IStaticModelBuilder
    {
        StaticModel _staticModel;
        public PillarGridModelBuilder()
        {
            _staticModel = new StaticModel("PillarGridModel");
        }

        #region IStaticModelBuilder Members
        public StaticModel StaticModel
        {
            get
            {
                return _staticModel;
            }
        }

        public void BuildFaults()
        {
            _staticModel.NumFaults = 2;
        }

        public void BuildGrid()
        {
            _staticModel.GridType = GridType.PILLAR_GRID;
        }

        public void BuildZones()
        {
            _staticModel.NumZones = 2;
        }
        #endregion
    }
}
