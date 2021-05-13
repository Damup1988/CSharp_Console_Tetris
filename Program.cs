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

            Point p1 = new Point(10, 5);
            p1.Draw('*');

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        p1.Draw(' ');
                        p1.x -= 1;
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        p1.Draw(' ');
                        p1.x += 1;
                    }
                }
                p1.Move();
                Thread.Sleep(500);
            }

            Console.SetCursorPosition(50, 30);
            Console.ReadLine();
        }
    }
}