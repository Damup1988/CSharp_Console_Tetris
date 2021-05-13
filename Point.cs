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

        public void Move()
        {
            Draw(' ');
            y += 1;
            Draw('*');
        }
    }
}
