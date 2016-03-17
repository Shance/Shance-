using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            Horizontalline Lines = new Horizontalline(1, 10, 9, '+');
            Lines.Draw();
            Vertikalline line = new Vertikalline(15, 25, 6, '&');
            line.Draw();
            Console.ReadLine();
        }
    }
}
