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
            Line topLine = new Line(new Point(1, 1), Direction.Right, 35);
            topLine.Draw();
            Line leftLine = new Line(new Point(1, 1), Direction.Down, 25);
            leftLine.Draw();
            Line rightLine = new Line(new Point(36, 1), Direction.Down, 25);
            rightLine.Draw();
            Line bottomLine = new Line(new Point(1, 25), Direction.Right, 35);
            bottomLine.Draw();
            #endregion

            Point p1 = new Point(18, 2);
            p1.Draw('*');

            while (!p1.hit_bottom_line)
            {
                p1.Move(leftLine.startPoint.x, rightLine.startPoint.x, bottomLine.startPoint.y);
                Thread.Sleep(250);
            }

            Console.SetCursorPosition(1, 26);
            Console.ReadLine();
        }
    }
}