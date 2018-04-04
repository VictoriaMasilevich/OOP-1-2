using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    class RectangleFabric : Fabric
    {
        public override MyDraw FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight)
        {
            return new Rectangle(fatness, color, upperLeft, lowerRight);
        }
    }
}
