using System;
using System.ComponentModel;

namespace Practice
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is amazing!!");
            Console.WriteLine(2+3);
            Console.Write("Par");
            Console.Write("deep");
            Console.WriteLine();
            //integer
            int a = 5;
            int b = 6;
            Console.WriteLine(a + b);
            //String
            string name = "pk";
            Console.WriteLine(name);
            //Integer
            int num = 20;
            num = 33;
            Console.WriteLine(num);
            //Constants
            const int numm = 34;
            //numm = 344; (Not possible to change constant value)
            Console.WriteLine(numm);
            //////////////////////////
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            long myLong = 1500000L;
            float myFloat = 5.75F;
            Console.WriteLine(myFloat);
            Console.WriteLine(myLong);
            Console.WriteLine(myText);
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myBool);
            Console.WriteLine(myLetter);
            //////////////////////////////
            //Display Variables
            string naam = "Pardeep";
            Console.WriteLine("Hello " + naam);
            /////////////////////////////////
            string firstName = "Pardeep ";
            string lastName = "Khatri";
            string fullName= firstName + lastName;
            Console.WriteLine(fullName);
            ////////////////////////////////
            ///Scientific Numbers
            float f1 = 35e3F; //e=10 e3=10**3;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            /////////////////////////////
            ///IMPLICIT CASTING
            int myIntT = 9;
            double myDoubleE = myIntT;       // Automatic casting: int to double

            Console.WriteLine(myIntT);      // Outputs 9
            Console.WriteLine(myDoubleE);   // Outputs 9
            //////////////////////////////
            ///EXPLICIT CASTING
            double myD = 9.78;
            int myI= (int)myD;    // Manual casting: double to int

            Console.WriteLine(myD);   // Outputs 9.78
            Console.WriteLine(myI);      // Outputs 9
            /////////////////////////////
            ///TYPE CONVERSION
            int myInt = 10;
            double myDouble = 5.25;
            bool myBoolL = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBoolL));   // convert bool to string
            /////////////////////////////////
            ///GET USER INPUT
            Console.WriteLine("Enter username:");
            string userName=Console.ReadLine();
            Console.WriteLine("Username is: "+userName);
            //////////////////////////////////
            ///USER INPUT AND NUMBERS
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: "+age);
            ////////////////////////////////////
            ///OPERATORS
            int X = 12;
            int Y = 20;
            Console.WriteLine("Add "+(X + Y));
            Console.WriteLine("Sub "+(X - Y));
            Console.WriteLine("Add++ "+(X++));
            Console.WriteLine("* "+(X*Y));
            Console.WriteLine("++Add "+(++Y));
            Console.WriteLine("Sub-- "+(X--));
            Console.WriteLine("Divide "+(X/Y));
            Console.WriteLine("% "+(X%Y));
            ///////////////////////////////////////
            /// C# NATH
            Console.WriteLine("Max value: ");
            Console.WriteLine(Math.Max(X, Y));
            Console.WriteLine("Min value: ");
            Console.WriteLine(Math.Min(X, Y));
            Console.WriteLine("SQRT: ");
            Console.WriteLine(Math.Sqrt(X));
            Console.WriteLine("Abs: ");
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine("Round off: ");
            Console.WriteLine(Math.Round(9.99));




        }
    }
}
