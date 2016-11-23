using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(2015, month, day);
            DateTime newDate = date.AddDays(5);
            Console.WriteLine("{0:d.MM}", date.AddDays(5));
        }
    }
}
