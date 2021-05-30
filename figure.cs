using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class figure
    {
        public int high { get; set; }
        public int width { get; set; }
        public List<Point> figures_points { get; set; } = new List<Point>();
        public static Point start_point { get; set; }
        public bool hit_currentBottom { get; set; }
        public bool hit_bottom_line { get; set; }
        public bool hit_left_line { get; set; }
        public bool hit_rigt_line { get; set; }

        public figure(int x, int y)
        {
            start_point = new Point(x, y);
        }

        public void Draw()
        {
            figures_points.Add(start_point);
            figures_points.Add(new Point(start_point.x - 1, start_point.y));
            figures_points.Add(new Point(start_point.x + 1, start_point.y));
            figures_points.Add(new Point(start_point.x + 2, start_point.y));
            foreach (var item in figures_points)
            {
                item.Draw('*');
            }
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
                        string key_str = "left";
                        foreach (var item in figures_points)
                        {
                            item.Move(leftBorder, rightBorder, bottomBorder, currentBottom, key_str);
                        }
                    }                    
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    if (!hit_rigt_line)
                    {
                        string key_str = "right";
                        foreach (var item in figures_points)
                        {
                            item.Move(leftBorder, rightBorder, bottomBorder, currentBottom, key_str);
                        }
                    }                    
                }
            }
            foreach (var item in figures_points)
            {
                item.Move(leftBorder, rightBorder, bottomBorder, currentBottom, "");
            }            
            foreach (var item in figures_points)
            {
                if (item.hit_currentBottom)
                {
                    hit_currentBottom = true;
                    break;
                }
                if (item.hit_bottom_line)
                {
                    hit_bottom_line = true;
                    break;
                }
            }
            foreach (var item in figures_points)
            {
                if (item.hit_left_line)
                {
                    hit_left_line = true;
                    break;
                }                
            }
            foreach (var item in figures_points)
            {
                if (item.hit_right_line)
                {
                    hit_rigt_line = true;
                    break;
                }
            }
        }
    }
}
