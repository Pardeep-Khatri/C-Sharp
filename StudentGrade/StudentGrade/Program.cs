using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student marks");
            Console.WriteLine("Marks of 1st subject");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks of 2nd subject");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks of 3rd subject");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks of 4th subject");
            int s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks of 5th subject");
            int s5 = Convert.ToInt32(Console.ReadLine());
            int s6 = ((s1 + s2 + s3 + s4 + s5 ) * 100)/600;
            if (s6 > 90) { Console.WriteLine("Excellent , you got " + s6 + " % and Grade A"); }
            else if (s6 > 80) { Console.WriteLine("Very Good , you got " + s6 + " % and Grade B"); }
            else if (s6 > 70) { Console.WriteLine("Good , you got " + s6 + " % and Grade C"); }
            else if (s6 > 50) { Console.WriteLine("you got " + s6 + " % and Grade D"); }
            else{ Console.WriteLine("FAIL, you got " + s6 + " % and Grade F"); }

        }
    }
}
