using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class figure
    {
        public int high { get; set; }
        public int width { get; set; }
        public List<Point> figures_points { get; set; }
        public Point start_point { get; set; }

        public figure(int x, int y)
        {
            x = start_point.x;
            y = start_point.y;
        }

        public void Draw()
        {
            figures_points.Add(start_point);
            figures_points.Add(new Point(start_point.x - 1, start_point.y));
            figures_points.Add(new Point(start_point.x + 1, start_point.y));
            figures_points.Add(new Point(start_point.x + 2, start_point.y));
            foreach (var item in figures_points)
            {
                item.Draw('*');
            }
        }

        public void Move(int leftBorder, int rightBorder, int bottomBorder, List<Point> currentBottom)
        {
            foreach (var item in figures_points)
            {
                item.Move(leftBorder, rightBorder, bottomBorder, currentBottom);
            }
        }
    }
}
