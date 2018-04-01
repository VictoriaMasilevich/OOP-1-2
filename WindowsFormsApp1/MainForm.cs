using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Draw(object sender, PaintEventArgs e)
        {
            Line line1 = new Line(200, 150, 300, 50);
            Line line2 = new Line(300, 50, 400, 150);
            Rectangle rectangle = new Rectangle(260, 250, 80, 90);
            Square square = new Square(200, 150, 200);
            Circle circle = new Circle(520, 10, 70);
            Ellipse ellipse = new Ellipse(315, 300, 15, 5);

            Point point1 = new Point(470, -2);
            Point point2 = new Point(500, 30);
            Point point3 = new Point(450, 45);
            Point point4 = new Point(510, 70);
            Point point5 = new Point(470, 110);
            Point point6 = new Point(530, 100);
            Point point7 = new Point(550, 150);
            Point point8 = new Point(570, 100);
            Point point9 = new Point(600, 140);
            Point[] curvePoints1 = { point1, point2, point3, point4, point5, point6, point7, point8, point9 };

            Curve curve1 = new Curve(curvePoints1);
          
            ObjectsList objectsList = new ObjectsList();
            objectsList.Add(line1);
            objectsList.Add(line2);
            objectsList.Add(square);
            objectsList.Add(rectangle);
            objectsList.Add(circle);
            objectsList.Add(ellipse);
            objectsList.Add(curve1);
            objectsList.Draw(e);
        }
    }
}
