using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointonSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            

            if (point>=Math.Min(first, second)&&point<=Math.Max(first, second))
            {
                Console.WriteLine("in");
                Console.WriteLine("{0}", Math.Min(Math.Abs(point - second), Math.Abs(point - first)));
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine("{0}", Math.Min(Math.Abs(point - second), Math.Abs(point - first)));
            }
        }
    }
}
