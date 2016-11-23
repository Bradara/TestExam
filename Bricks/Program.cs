using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = int.Parse(Console.ReadLine());
            var worker = int.Parse(Console.ReadLine());
            var volumeOfCar = int.Parse(Console.ReadLine());

            var courses =Math.Ceiling((decimal)bricks /( worker * volumeOfCar));
            Console.WriteLine(courses);
        }
    }
}
