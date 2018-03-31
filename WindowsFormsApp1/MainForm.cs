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
            Line line = new Line(100, 100, 200, 200);
            ObjectsList objectsList = new ObjectsList();
            objectsList.Add(line);
            objectsList.Draw(e);
        }
    }
}
