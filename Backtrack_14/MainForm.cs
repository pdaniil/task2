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
    public partial class MainForm : Form
    {
        List<Point> pointList = new List<Point>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            using (PointForm pointForm = new PointForm(null))
            {
                if (pointForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                AddPoint(pointForm.point);
                PointsToDgv();
            }
        }

        private void AddPoint(Point point)
        {
            if (FindPointIndex(point) == -1) {
                pointList.Add(point);
            }
        }

        private int FindPointIndex(Point point)
        {
            return pointList.FindIndex(p => p.X == point.X && p.Y == point.Y && p.Z == point.Z);
        }
        private void PointsToDgv()
        {
            dgv.DataSource = null;
            dgv.DataSource = pointList;
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                return;
            }
            pointList.Remove(dgv.SelectedRows[0].DataBoundItem as Point);
            PointsToDgv();
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            pointList.Clear();
            PointsToDgv();
        }

        private double GetDistanceBetweenPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2) + Math.Pow(p2.Z - p1.Z, 2));
        }

        private Point GetCenterPoint(List<Point> points)
        {
            Point centerPoint = new Point(0, 0, 0);
            foreach (Point point in points)
            {
                centerPoint.X += point.X;
                centerPoint.Y += point.Y;
                centerPoint.Z += point.Z;
            }
            centerPoint.X /= points.Count;
            centerPoint.Y /= points.Count;
            centerPoint.Z /= points.Count;
            return centerPoint;
        }

        private List<Point> firstSet = new List<Point>();
        private List<Point> secondSet = new List<Point>();
        double distance = double.MaxValue;

        private void BackTrack(List<Point> firstSet, List<Point> secondSet, int count)
        {
            if (count == pointList.Count && firstSet.Count > 0 && secondSet.Count > 0)
            {
                double distance = GetDistanceBetweenPoints(GetCenterPoint(firstSet), GetCenterPoint(secondSet));
                if (this.distance > distance)
                {
                    this.distance = distance;
                    this.firstSet.Clear();
                    this.secondSet.Clear();
                    foreach (Point point in firstSet)
                    {
                        this.firstSet.Add(point);
                    }
                    foreach (Point point in secondSet)
                    {
                        this.secondSet.Add(point);
                    }
                }
            }
            else if (count < pointList.Count)
            {
                firstSet.Add(pointList[count]);
                BackTrack(firstSet, secondSet, count + 1);
                firstSet.Remove(pointList[count]);
                secondSet.Add(pointList[count]);
                BackTrack(firstSet, secondSet, count + 1);
                secondSet.Remove(pointList[count]);
            }
        }

        private void BtTask_Click(object sender, EventArgs e)
        {
            BackTrack(new List<Point>(), new List<Point>(), 0);
            MessageBox.Show("Расстояние: " + distance.ToString());
        }
    }
}
