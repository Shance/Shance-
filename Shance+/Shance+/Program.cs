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
            Console.SetBufferSize(80, 25);
            //Отрисовка рамки
            Horizontalline upline = new Horizontalline(0, 78, 0, '+');
            Horizontalline downline = new Horizontalline(0, 78, 24, '+');
            Vertikalline leftline = new Vertikalline(0, 24, 0, '+');
            Vertikalline rightline = new Vertikalline(0, 24, 78, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();
            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.right);
            snake.Draw();
        }
    }
}
