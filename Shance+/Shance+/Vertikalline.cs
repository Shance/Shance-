using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shance_
{
    class Vertikalline
    {
        List<Point> plist;
        public Vertikalline(int ytop, int ybottom, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = ytop; y <= ybottom; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}