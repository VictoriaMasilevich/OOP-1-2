using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
    class ObjectsList
    {
        private List<MyDraw> myList = new List<MyDraw>();
        public ObjectsList()
        {
            this.myList = new List<MyDraw>();
        }
        public void Add(MyDraw myDraw)
        {
            myList.Add(myDraw);
        }
        public void Draw(PaintEventArgs e)
        {
            foreach (MyDraw myDraw in myList)
            {
                myDraw.Draw(e);
            }
        }
    }
}
