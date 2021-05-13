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

            bool hit_bottom_line = false;
            bool hit_left_line = false;
            bool hit_right_line = false;

            Point p1 = new Point(18, 2);
            p1.Draw('*');

            while (!hit_bottom_line)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        if (!hit_left_line)
                        {
                            p1.Draw(' ');
                            p1.x -= 1;
                        }                        
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        if (!hit_right_line)
                        {
                            p1.Draw(' ');
                            p1.x += 1;
                        }                        
                    }
                }
                p1.Move();
                Thread.Sleep(500);
                if (p1.y == bottomLine.startPoint.y - 1)
                {
                    hit_bottom_line = true;
                }
                if (p1.x == leftLine.startPoint.x + 1)
                {
                    hit_left_line = true;
                }
                if (p1.x == rightLine.startPoint.x - 1)
                {
                    hit_right_line = true;
                }
            }

            Console.SetCursorPosition(50, 30);
            Console.ReadLine();
        }
    }
}