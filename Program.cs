using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            #region -=BORDERS=-

            int playAreaHigh = 35;
            int playAreaWidth = 35;

            Line topLine = new Line(new Point(1, 1), Direction.Right, playAreaWidth);
            topLine.Draw();
            Line leftLine = new Line(new Point(1, 1), Direction.Down, playAreaHigh);
            leftLine.Draw();
            Line rightLine = new Line(new Point(playAreaWidth, 1), Direction.Down, playAreaHigh);
            rightLine.Draw();
            Line bottomLine = new Line(new Point(1, playAreaHigh), Direction.Right, playAreaWidth);
            bottomLine.Draw();
            #endregion

            List<Point> currentBottom = new List<Point>();
            
            while (true)
            {
                Point p1 = new Point(18, 2);
                p1.Draw('*');

                while (!p1.hit_bottom_line & !p1.hit_currentBottom)
                {
                    p1.Move(leftLine.startPoint.x, rightLine.startPoint.x, bottomLine.startPoint.y, currentBottom);
                    Thread.Sleep(250);
                }                                
                currentBottom.Add(p1);
            }

            Console.SetCursorPosition(1, 26);
            Console.ReadLine();
        }
    }
}