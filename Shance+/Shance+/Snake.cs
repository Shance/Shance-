using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shance_
{
    class Snake: Figure
    {
        private List<Point> plist;

        public Snake(Point tail, int lenght, Direction direction)
        {
            plist = new List<Point>();
            for(int i=0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                plist.Add(p);
            }
        }
}
