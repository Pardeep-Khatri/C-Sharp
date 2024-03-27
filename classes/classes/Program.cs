using classes.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sodhi = new Person();
            sodhi.FirstName = "Roshan Singh";
            sodhi.LastName = "Sodhi";
            sodhi.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1,3);
            Console.WriteLine(result);
        }
    }
}
