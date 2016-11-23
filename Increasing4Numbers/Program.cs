using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ((b-a)>2)
            {
                for (int col1 = a; col1 <= b; col1++)
                {
                    for (int col2 = col1+1; col2 <= b; col2++)
                    {
                        for (int col3 = col2+1; col3 <= b; col3++)
                        {
                            for (int col4 = col3+1; col4 <= b; col4++)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", col1, col2, col3, col4);
                            }
                        }
                    }
                }
            }
            else Console.WriteLine("No");

            
        }
    }
}
