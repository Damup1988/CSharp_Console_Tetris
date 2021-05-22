using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool hit_bottom_line { get; set; }
        bool hit_left_line { get; set; }
        bool hit_right_line { get; set; }
        public bool hit_currentBottom { get; set; }    

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw(char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public void Move(int leftBorder, int rightBorder, int bottomBorder, List<Point> currentBottom)
        {            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (!hit_left_line)
                    {
                        Draw(' ');
                        x -= 1;
                    }
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (!hit_right_line)
                    {
                        Draw(' ');
                        x += 1;
                    }
                }
            }
            Draw(' ');
            y += 1;
            Draw('*');
            if (y == bottomBorder - 1)
            {
                hit_bottom_line = true;
            }
            if (x == leftBorder + 1)
            {
                hit_left_line = true;
            }
            if (x == rightBorder - 1)
            {
                hit_right_line = true;
            }
            foreach (var item in currentBottom)
            {
                if (y == item.y -1 & x == item.x)
                {
                    hit_currentBottom = true;
                    break;
                }
            }
        }
    }
}
