using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPassGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            l += 'a';

            for (int col1 = 1; col1 <= n; col1++)
            {
                for (int col2 = 1; col2 <= n; col2++)
                {
                    for (char col3 = 'a'; col3 < l; col3++)
                    {
                        for (char col4 = 'a'; col4 < l; col4++)
                        {
                            for (int col5 = (col1 > col2) ? col1 + 1 : col2 + 1; col5 <= n; col5++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", col1, col2, col3, col4, col5);
                            }
                        }
                    }
                }
            }
        }
    }
}
