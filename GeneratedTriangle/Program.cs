using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratedTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointN = int.Parse(Console.ReadLine());
            int areaM = int.Parse(Console.ReadLine());
            bool notArea = true;
            for (int x1 = pointN*-1; x1 <= pointN; x1++)
            {
                for (int y1 = pointN*-1; y1 <= pointN; y1++)
                {
                    for (int x2 = x1; x2 <= pointN; x2++)
                    {
                        for (int y2 = y1; y2 <= pointN; y2++)
                        {
                            int a = x2 - x1;
                            int b = y2 - y1;
                            if (a * b >= areaM&&a>0)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",
                                                  x1, y1, x2, y2, a * b);
                                notArea = false;
                            }

                        }
                    }
                }

            }
            if (notArea)
            {
                Console.WriteLine("No");
            }
        }
    }
}
