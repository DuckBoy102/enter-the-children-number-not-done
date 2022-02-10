using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            Console.WriteLine("enter the children number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the chairs number");
            y = int.Parse(Console.ReadLine());
            z = (x - y);
            if (z >= 0)
                Console.WriteLine("we need {0} more chairs", z);
            else
                Console.WriteLine("ok");
        }
    }
}
