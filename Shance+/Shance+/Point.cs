using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shance_
     {
       class Point
       {
        public int x;
        public int y;
        public char sym;
        public Point()
        {
        }
        public Point(int _x, int _y, Char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void move(int offset, Direction direction)
        {
            if (direction == Direction.right)
            {
                x = x + offset;
            }
            else if (direction == Direction.left)
            {
                x = x - offset;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
