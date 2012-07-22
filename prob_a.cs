using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Solution
{
    struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Solution
    {
        static void Main(string[] args)
        {
            int d = 0;
            var c = int.Parse(Console.ReadLine());
            List<Point> pl = new List<Point>();
            for (int i = 0; i < c; i++)
            {
                var s = Console.ReadLine().Split(' ');
                pl.Add(new Point(int.Parse(s[0]), int.Parse(s[1])));
            }
 
            for (int i = 0; i < pl.Count-1; i++)
            {
                for (int j = i; j < pl.Count; j++)
                {
                    int dx = pl[i].x - pl[j].x;
                    int dy = pl[i].y - pl[j].y;
                    int td = dx * dx + dy * dy;
                    if (td > d) d = td;
                }
            }
 
            Console.WriteLine(Math.Sqrt(d));
        }
    }
}