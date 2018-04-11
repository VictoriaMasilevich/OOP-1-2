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
        private Fabric figureCreator;
        string selectedColor;

        public MainForm()
        {
            InitializeComponent();
            bmap = new Bitmap(PictureBox.Size.Width, PictureBox.Size.Height);
            graphics = Graphics.FromImage(bmap);
        }

        private void DrawAllButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            Ellipse ellipse = new Ellipse();
            Line line = new Line();
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            ObjectsList objectsList = new ObjectsList();
            objectsList.myList.Add(line);
            objectsList.myList.Add(square);
            objectsList.myList.Add(rectangle);
            objectsList.myList.Add(circle);
            objectsList.myList.Add(ellipse);
            objectsList.Draw(graphics);
            PictureBox.Image = bmap;
        }

        ObjectsList objectsList = new ObjectsList();

        Color penColor = Color.RosyBrown;
        Pen pen = new Pen(Color.RosyBrown, 2);

        public bool isClicked = false;

        public struct MenuItemInfo
        {
            public string figureName;
            public string creatorType;
            public Fabric FigureCreator;
        }

        Point X;
        Point Y;
        Figure figure;

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (figureCreator != null)
            {
                figure = figureCreator.Create();
                if (selectedColor == null)
                {
                    selectedColor = "Gray";
                }
                penColor = Color.FromName(selectedColor);
                pen = new Pen(penColor, 2);
                figure.Pen = pen;
                isClicked = true;
                X = new Point(e.X, e.Y);
            }
        }


        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
            if (figure != null)
            {
                objectsList.myList.Add(figure);
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                Y = new Point(e.X, e.Y);
                PictureBox.Invalidate();
            }
        }

        public void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (figure != null)
            {
                figure.StartPoint = X;
                figure.FinishPoint = Y;
                if (selectedColor == null)
                {
                    selectedColor = "Gray";
                }
                penColor = Color.FromName(selectedColor);
                pen = new Pen(penColor, 2);
                figure.Draw(e.Graphics, figure.Pen, figure.StartPoint, figure.FinishPoint);
                if (objectsList.myList.Count > 0)
                {
                    foreach (var fig in objectsList.myList)
                    {
                        fig.Draw(e.Graphics, fig.Pen, fig.StartPoint, fig.FinishPoint);
                    }
                }
            }
        }

        private void rb_square_CheckedChanged(object sender, EventArgs e)
        {
            figureCreator = new SquareFabric();
        }

        private void rb_reactangle_CheckedChanged(object sender, EventArgs e)
        {
            figureCreator = new RectangleFabric();
        }

        private void rb_ellipse_CheckedChanged(object sender, EventArgs e)
        {
            figureCreator = new EllipseFabric();
        }

        private void rb_circle_CheckedChanged(object sender, EventArgs e)
        {
            figureCreator = new CircleFabric();
        }

        private void rb_line_CheckedChanged(object sender, EventArgs e)
        {
            figureCreator = new LineFabric();
        }

        private void listbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedColor = listbx.SelectedItem.ToString();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            PictureBox.Image = null;
        }
    }
}
