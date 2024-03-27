using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> odd = ((ParallelQuery<int>)ParallelEnumerable.Range(10,200))
       .Where(x => x % 2 != 0)
       .Select(i => i);
            foreach (int n in odd) { Console.WriteLine(n); }
            Console.ReadLine();
        }
    }
}
