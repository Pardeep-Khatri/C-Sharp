using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************First Method using concat()***************");
            string firstName = "Pardeep ";
            string lastName = "Khatri";
            Console.WriteLine(string.Concat(firstName, lastName));
            Console.WriteLine();
            Console.WriteLine("**************Second Method using (+)*********************");
            string FirstName1 = "Pardeep ";
            string lastName1 = "Khatri";
            string fullName=FirstName1 + lastName1;
            Console.WriteLine(fullName);
        }
    }
}
