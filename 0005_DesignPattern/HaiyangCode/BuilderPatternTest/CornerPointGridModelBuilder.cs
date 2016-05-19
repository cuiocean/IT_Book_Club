using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternTest
{
    class CornerPointGridModelBuilder: IStaticModelBuilder
    {
        StaticModel _staticModel;
        public CornerPointGridModelBuilder()
        {
            _staticModel = new StaticModel("CornerPointGridModel");
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
            _staticModel.NumFaults = 3;
        }

        public void BuildGrid()
        {
            _staticModel.GridType = GridType.CORNERPOINT_GRID;
        }

        public void BuildZones()
        {
            _staticModel.NumZones = 3;
        }
        #endregion
    }
}
