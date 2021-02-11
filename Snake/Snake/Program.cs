using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.SetBufferSize(80, 20);
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            snake.Move();
            snake.Move();
            snake.Move();

            Console.ReadKey();
        }
    }
}
