using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backtrack_14
{
    public partial class PointForm : Form
    {
        public Point point;
        public PointForm(Point point)
        {
            InitializeComponent();
            if (point != null)
            {
                this.point = point;
                nudX.Value = (decimal)point.X;
                nudY.Value = (decimal)point.Y;
                nudZ.Value = (decimal)point.Z;
            }

        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (point != null)
            {
                point.X = (int)nudX.Value;
                point.Y = (int)nudY.Value;
                point.Z = (int)nudZ.Value;
            }
            else
            {
                point = new Point((int)nudX.Value, (int)nudY.Value, (int)nudZ.Value);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
