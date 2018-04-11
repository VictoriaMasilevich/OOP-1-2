using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    class EllipseFabric : Fabric
    {
        public override Figure Create()
        {
            return new Ellipse();
        }
    }
}
