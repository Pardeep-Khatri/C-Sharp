using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetToInches
{
    public delegate double Conversion(double from);
    class DelegateD
    {
        public static double FeetToInches(double feet)
        {
            return feet * 12;
        }
        static void Main()
        {
            Conversion doConversion = new Conversion(FeetToInches);
            Console.Write("Enter Feet = ");
            double feet = Double.Parse(Console.ReadLine());
            double inches = doConversion(feet);
            Console.WriteLine("\n{0} Feet = {1} Inches.\n", feet, inches);
           
            Console.Beep();
        }
    }
}
