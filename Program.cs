using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        public void Draw(Point point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.WriteLine("*");
        }
        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}