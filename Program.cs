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

            int playAreaHigh = 15;
            int playAreaWidth = 15;
            int row_length = playAreaWidth - 2;
            int column_high = playAreaHigh - 2;

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

            int score = 0;
            bool gameover = false;
            do
            {
                #region -=game with points=-
                //Point p1 = new Point(8, 2);
                //p1.Draw('*');

                //while (!p1.hit_bottom_line & !p1.hit_currentBottom)
                //{
                //    p1.Move(leftLine.startPoint.x, rightLine.startPoint.x, bottomLine.startPoint.y, currentBottom);
                //    Thread.Sleep(250);
                //}
                //currentBottom.Add(p1);
                //var rows_numbers = currentBottom.Select(x => x.y).Distinct().ToList();
                //foreach (var uniq_row_number in rows_numbers)
                //{
                //    int col = 0;
                //    foreach (var cur_bottom_point in currentBottom)
                //    {
                //        if (cur_bottom_point.y == uniq_row_number)
                //        {
                //            col++;
                //        }
                //    }
                //    if (col == row_length)
                //    {
                //        foreach (var cur_bottom_point in currentBottom)
                //        {
                //            cur_bottom_point.Draw(' ');
                //        }
                //        currentBottom.RemoveAll(i => i.y == uniq_row_number);
                //        foreach (var cur_bottom_point in currentBottom)
                //        {
                //            cur_bottom_point.y += 1;
                //            cur_bottom_point.Draw('*');
                //        }
                //        score += 100;
                //        Console.SetCursorPosition(7, 20);
                //        Console.WriteLine($"SCORE: {score}");
                //    }
                //}
                //if (currentBottom.Count == column_high)
                //{
                //    gameover = true;
                //    Point p2 = new Point(8, 2);
                //    p2.Draw('*');
                //}
                #endregion

                figure f1 = new figure(8, 2);
                f1.Draw();
                while (!f1.hit_bottom_line & !f1.hit_currentBottom)
                {
                    f1.Move(leftLine.startPoint.x, rightLine.startPoint.x, bottomLine.startPoint.y, currentBottom);
                    Thread.Sleep(1000);
                }
                foreach (var item in f1.figures_points)
                {
                    currentBottom.Add(item);
                }
            }
            while (!gameover);

            Console.SetCursorPosition(1, 20);
            Console.WriteLine("GAME OVER!");
            Console.ReadLine();
        }
    }
}