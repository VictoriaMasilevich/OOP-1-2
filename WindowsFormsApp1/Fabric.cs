using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
    abstract class Fabric
    {
        public abstract MyDraw FactoryMethod(float fatness, Color color, Point upperLeft, Point lowerRight);
    }
}
