using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    class CircleFabric : Fabric
    {
        public override MyDraw FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight)
        {
            return new Circle(fatness, color, upperLeft, lowerRight);
        }
    }
}
