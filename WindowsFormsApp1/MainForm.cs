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
        public Bitmap bmap;
        public Graphics graphics;
        private MyDraw mydraw;
        private Fabric maker;
        string selectedColor;

        public MainForm()
        {
            InitializeComponent();
            bmap = new Bitmap(PictrueBox.Size.Width, PictrueBox.Size.Height);
            graphics = Graphics.FromImage(bmap);
        }

        private void DrawAllButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(2, Color.Aqua, new Point(10, 10), new Point(70, 70));
            Ellipse ellipse = new Ellipse(2, Color.Pink, new Point(10, 80), new Point(140, 150));
            Line line = new Line(2, Color.Lime, new Point(10, 170), new Point(120, 190));
            Square square = new Square(2, Color.LightSeaGreen, new Point(10, 210), new Point(90, 90));
            Rectangle rectangle = new Rectangle(2, Color.Orange, new Point(10, 310), new Point(250, 390));
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
            Curve curve1 = new Curve(2, Color.Black, curvePoints1);
            ObjectsList objectsList = new ObjectsList();
            objectsList.Add(line);
            objectsList.Add(square);
            objectsList.Add(rectangle);
            objectsList.Add(circle);
            objectsList.Add(ellipse);
            objectsList.Add(curve1);
            objectsList.Draw(graphics);
            PictrueBox.Image = bmap;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            PictrueBox.Image = bmap;
        }

        private bool IsInt(string x1, string y1, string x2, string y2)
        {
            int res = 0;
            if (Int32.TryParse(x1, out res) && Int32.TryParse(y1, out res) && Int32.TryParse(x2, out res) && Int32.TryParse(y2, out res))
            {
                return true;
            }
            return false;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (maker != null)
            {
                if (selectedColor == null)
                {
                    selectedColor = "black";
                }
                if (IsInt(tb_x1.Text, tb_y1.Text, tb_x2.Text, tb_y2.Text))
                {
                    mydraw = maker.FactoryMethod(2, Color.FromName(selectedColor),
                                    new Point(Convert.ToInt32(tb_x1.Text, 10), Convert.ToInt32(tb_y1.Text, 10)),
                                    new Point(Convert.ToInt32(tb_x2.Text, 10), Convert.ToInt32(tb_y2.Text, 10)));
                    mydraw.Draw(graphics);


                    PictrueBox.Image = bmap;
                }
                else
                {
                    MessageBox.Show("Введены некорректные координаты!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите фигуру!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_square_CheckedChanged(object sender, EventArgs e)
        {
            maker = new SquareFabric();
        }

        private void rb_reactangle_CheckedChanged(object sender, EventArgs e)
        {
            maker = new RectangleFabric();
        }

        private void rb_ellipse_CheckedChanged(object sender, EventArgs e)
        {
            maker = new EllipseFabric();
        }

        private void rb_circle_CheckedChanged(object sender, EventArgs e)
        {
            maker = new CircleFabric();
        }

        private void rb_line_CheckedChanged(object sender, EventArgs e)
        {
            maker = new LineFabric();
        }

        private void listbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedColor = listbx.SelectedItem.ToString();
        }
    }
}
