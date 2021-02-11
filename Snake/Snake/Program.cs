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
            HorizontalLine line = new HorizontalLine(5, 10, 8, '*');
            VerticalLine vline = new VerticalLine(5, 3, 18, '#');
            line.Draw();
            vline.Draw();
            Console.ReadKey();
        }
    }
}
