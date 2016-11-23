using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("/{0}{1}{2}{2}/{0}{1}", new string('^', n/2), (char)092, new string('_', n-2-n/2));
            for (int i = 0; i < n-2; i++)
            {
                if (n>4&&i==n-3)
                {
                    Console.WriteLine("|{0}{1}{1}{0}|", new string(' ', n / 2+1),new string('_', n - 2 - n / 2) );
                }
                else Console.WriteLine("|{0}|", new string(' ', 2*n-2));
                
            }
            Console.WriteLine("{0}{1}/{2}{2}{0}{1}/", (char)092, new string('_', n/2), new string(' ', n - 2 - n / 2));
        }
    }
}
