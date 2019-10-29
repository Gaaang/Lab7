using AffineTransformationsIn3D.Geometry;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AffineTransformationsIn3D
{
    public partial class FormChangeModel : Form
    {
        public Mesh SelectedModel { get; private set; }

		private Camera _this_camera;

		public FormChangeModel(Camera this_camera)
        {
            InitializeComponent();
			_this_camera = this_camera;
        }
        private void AddPoint(object sender, EventArgs e)
        {
            var x = (double)numericUpDownX.Value;
            var y = (double)numericUpDownY.Value;
            var z = (double)numericUpDownZ.Value;
            numericUpDownX.Value = 0;
            numericUpDownY.Value = 0;
            numericUpDownZ.Value = 0;
            listBoxPoints.Items.Add(new Vector(x, y, z));
        }

        private void SelectedPointChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = null != listBoxPoints.SelectedItem;
        }

        private void RemovePoint(object sender, EventArgs e)
        {
            listBoxPoints.Items.RemoveAt(listBoxPoints.SelectedIndex);
        }

        private static double F(double x, double y)
        {
            double r = x * x + y * y;
            return Math.Cos(r) / (r + 1);
        }

        private void Ok(object sender, EventArgs e)
        {
            var tab = tabControl1.SelectedTab;
            if (tabPagePolyhedron == tab)
            {
                if (radioButtonTetrahedron.Checked)
                    SelectedModel = Models.Tetrahedron(0.5);
                else if (radioButtonIcosahedron.Checked)
                    SelectedModel = Models.Icosahedron(0.5);
                else if(radioButtonCube.Checked)
                    SelectedModel = Models.Cube(0.5);
            }
            else if (tabPageRotationFigure == tab)
            {
                IList<Vector> initial = new List<Vector>(listBoxPoints.Items.Count);
                foreach (var v in listBoxPoints.Items)
                    initial.Add((Vector)v);
                int axis;
                if (radioButtonX.Checked) axis = 0;
                else if (radioButtonY.Checked) axis = 1;
                else /* if (radioButtonZ.Checked) */ axis = 2;
                var density = (int)numericUpDownDensity.Value;
                SelectedModel = Models.RotationFigure(initial, axis, density);
            }
            else if (tabPagePlot == tab)
                SelectedModel = Models.Plot(-0.8, 0.8, 0.1, -0.8, 0.8, 0.1, F);
        }
    }
}
