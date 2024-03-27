using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 100, 99, 87, 65, 0, 28, 44 };
            var greater = from num in numbers where num > 50 select num;
            Console.WriteLine("Numbers Greater than 50 : ");
            foreach ( var s in greater)
            {
                Console.WriteLine(s.ToString()+" ");
            }
            Console.Read();
        }
    }
}
