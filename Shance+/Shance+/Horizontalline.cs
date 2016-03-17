using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shance_
{
    class Horizontalline
    {
        List<Point> plist;
        public Horizontalline(int xleft, int xrigth, int y, char sym)
        {
            plist = new List<Point>();
            for(int x=xleft; x<=xrigth; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
        public void Draw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
