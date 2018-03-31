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
            MainForm_Window();
        }

        private void MainForm_Window()
        {
            PictureBox pct = new PictureBox();
            pct.Height = 300;
            pct.Width = 600;
            pct.BackColor = Color.White;
            Controls.Add(pct);
        }
    }
}
