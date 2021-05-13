using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Line
    {
        public Point startPoint { get; set; }
        public Direction direction { get; set; }
        public int length { get; set; }

        public Line(Point startPoint, Direction direction, int length)
        {
            this.startPoint = startPoint;
            this.direction = direction;
            this.length = length;
        }

        public void Draw()
        {
            if (direction == Direction.Right)
            {
                for (int i = 0; i < length; i++)
                {
                    startPoint.Draw('*');
                    startPoint.x += 1;
                }
            }
            if (direction == Direction.Down)
            {
                for (int i = 0; i < length; i++)
                {
                    startPoint.Draw('*');
                    startPoint.y += 1;
                }
            }
        }
    }
}
