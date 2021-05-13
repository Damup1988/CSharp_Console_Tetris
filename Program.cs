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