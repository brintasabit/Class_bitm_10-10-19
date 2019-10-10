using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleUi
{
    public partial class CircleMeasurement : Form
    {
        public CircleMeasurement()
        {
            InitializeComponent();
        }
        Circle circle=new Circle();
        private void buttonGet_Click(object sender, EventArgs e)
        {
            circle.radius = Convert.ToInt32(textBoxRadius.Text);
            labelDiameter.Text = Convert.ToString(circle.Diameter());
            labelPerimeter.Text = Convert.ToString(circle.Perimeter());
            labelArea.Text = Convert.ToString(circle.Area());
        }
    }
}
