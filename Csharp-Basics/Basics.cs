//using System; means we can use class from System
//The curly braces {} marks the begining and the end of a block of code

//Comments
//Single-line comment
/*
 Multi-line
 comment
*/

//namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics //Namespace of Csharp-Basics
{
    class Basics //Basics class
    {
        static void Main(string[] args) //Main method
        {
            _HelloWorld(); //Call _HelloWorld() method
            _Types();
            _Casting();
            _TypeConversion();
            _UserInput();
            _FormattedOutput();
            _Operators();
            _Math();
            _Strings();
            _Conditions();
            _Arrays();
            _Loops();
            myName("Bob");
            Console.WriteLine(add(5, 4)); //Prints out 9

            Console.ReadKey(); //Exit on key press
        }

        private static void _HelloWorld() //_HelloWorld method
        {
            Console.Write("Hello World!"); //Prints out: Hello World!
            Console.WriteLine(" I'm learning C#."); //Prints out in the same line. Hello World! I'm learning C#.
        }

        private static void _Types()
        {
            //Declaring variables:
            //type variable = value;

            //Types
            byte b = 27; //8 bit whole number, 0..255
            char ch = 'a'; //Stores exactly one character between '' characters
            bool boolean = false; //Boolean, 0 or 1
            sbyte sb = 27; //8 bit whole number, -128..127
            short sh = 27; //16 bit whole number, -32768..32767
            ushort ush = 27; //16 bit whole number, 0..65535
            int integer = 27; //32-bit whole number, 2,147,483,647..-2,147,483,647
            uint uinteger = 27; //32bit whole number 0..4294967295
            double doublePrecision = 4.75; //Double-precision floating-point number
            float floatingPoint = 22332; //Single-precision floating-point number
            decimal decimalNumber = 27; //Decimal floating-point number
            long longNumber = 270000000000000; //64 bit signed integer 
            ulong ulongNumber = 27000000; //64 bit unsigned integer
            string quote = "C# is not hard."; //While an individual quoted string cannot be longer than 2048 bytes, a string literal of roughly 65535 bytes can be constructed by concatenating strings.
            object any = 27; //Any type can be

            /*Optional: const
             *- Useful when you want a variable to always store the same value
             *ie.: const int constant = 27;
            */
        }

        private static void _Casting()
        {
            //Implicit Casting: Implicit casting is done automatically when passing a smaller size type to a larger size type
            int apples = 5;
            double averageApples = apples;

            //Explicit Casting: Explicit casting must be done manually by placing the type in parentheses in front of the value
            double averageGrades = 4.75;
            int grades = (int)averageGrades;

            Console.WriteLine(grades); //Prints out: 4
        }

        private static void _TypeConversion()
        {
            int apples = 27;
            double averageGrades = 4.75;
            bool amIHungry = true;

            Console.WriteLine(Convert.ToString(apples)); //Convert int to string
            Console.WriteLine(Convert.ToInt32(averageGrades)); //Convert double to int
            Console.WriteLine(Convert.ToString(amIHungry)); //Convert boolean to string
        }

        private static void _UserInput()
        {
            Console.Write("What is your name? "); //Asks the user of his/her name.
            string userName = Console.ReadLine(); //Stores user's name in userName variable which is string, so it will not work with other types.
            Console.WriteLine(userName); //Prints out the user's input
        }

        private static void _FormattedOutput()
        {
            string name = "Bob";
            int age = 27;
            Console.WriteLine($"Name: {name}; Age: {age}"); //Write $ before ", then insert {} between "" and inside {} your can call your variable
            //OR
            Console.WriteLine("Name: " + name + "; " + "Age: " + age); //Insert + then after you can call your variable
            //OR
            Console.WriteLine("Name: {0}; Age: {1}", name, age); //Inside {} you can call the variable by the index
        }

        private static void _Operators()
        {
           //Arithmetic Operators
            //Addition
            int firstNumber = 2;
            int secondNumber = 5;
            int results = firstNumber + secondNumber;

            //Subtraction
            results = firstNumber - secondNumber;

            //Multiplication
            results = secondNumber * firstNumber;

            //Division
            results = firstNumber / secondNumber;

            //Modulus
            results = firstNumber % secondNumber;

            //Increment
            results = firstNumber++;

            //Decrement
            results = secondNumber--;

           //Assignment Operators
            //=
            results = 5;

            //+
            results = firstNumber + 55;

            //-
            results = secondNumber - 1;

            //*
            results = firstNumber * 3;

            // /
            results = secondNumber / 2;

            //%
            results = firstNumber % 1;

            //&
            results = secondNumber & 3;

            //|
            results = firstNumber | 5;

            //^
            results = secondNumber ^ 4;

            //>>
            results = firstNumber >> 3;

            //<<
            results = secondNumber << 5;

           //Comparison Operators
            //Equal to
            Console.WriteLine(firstNumber == secondNumber);

            //Not equal
            Console.WriteLine(firstNumber != secondNumber);

            //Greater than
            Console.WriteLine(firstNumber > secondNumber);

            //Less than
            Console.WriteLine(firstNumber < secondNumber);

            //Greater than or equal to
            Console.WriteLine(firstNumber >= secondNumber);

            //less than or equal to
            Console.WriteLine(firstNumber <= secondNumber);

           //Logical Operators
            //Logical and
            Console.WriteLine(firstNumber < 5 && firstNumber < 6);

            //Logical or
            Console.WriteLine(firstNumber == 5 || secondNumber == 5);

            //Logical not
            Console.WriteLine(!(firstNumber == secondNumber));
        }

        private static void _Math()
        {
            int x = -5;
            double y = 4.67;

            //Returns the highest value
            Console.WriteLine(Math.Max(x, y));

            //Returns the lowest value
            Console.WriteLine(Math.Min(x, y));

            //Returns the square root
            Console.WriteLine(Math.Sqrt(x));

            //Returns the absolute value
            Console.WriteLine(Math.Abs(x));

            //Returns the nearest whole number
            Console.WriteLine(Math.Round(y));
        }

        private static void _Strings()
        {
            //Length of string
            string sentence = "Great day today.";
            int lengthOfSentence = sentence.Length; //Returns the length of sentence

            //ToUpper and ToLower
            string upper = sentence.ToUpper();
            string lower = sentence.ToLower();

            //Concatenation
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName; //Returns John Doe
            //OR
            string _fullName = string.Concat(firstName, lastName);

            //Access Strings
            Console.WriteLine(fullName[0]); //Returns J

            //Get character by index
            Console.WriteLine(fullName.IndexOf("o"));

            //Substring
            Console.WriteLine(fullName.Substring(1, 4)); //Returns irst

            //Special characters in output
            string txt = "\'Single quote\'"; //Returns 'Single quote'
            txt = "\"Double quote\""; //Returns "Double quote"
            txt = "\\Backslash\\"; //Returns \Backslash\
        }

        private static void _Conditions()
        {
           //If-Else if-Else
            //If, ie.: If cake is chocolate return favourite
            string cake = "Chocolate";

            if (cake == "Chocolate")
                Console.WriteLine("My favourite cake!");

            //If-else, ie.: If cake is chocolate return favourite else return nope
            if(cake == "Chocolate")
                Console.WriteLine("My favourite cake!");
            else
                Console.WriteLine("Nope");

            //If-else if-else, ie.: If cake is chocolate return favourite else if caramel return yamy else return nope
            if(cake == "Chocolate")
                Console.WriteLine("My favourite cake!");
            else if(cake == "Caramel")
                Console.WriteLine("Yamy");
            else
                Console.WriteLine("Nope");

            //Switch
            string league = "laliga";
            switch (league)
            {
                case "laliga":
                    Console.WriteLine(league);
                    break;
                case "bundesliga":
                    Console.WriteLine(league);
                    break;
                default:
                    Console.WriteLine("serie a");
                    break;
            }
        }

        private static void _Arrays()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Renault" };
            Console.WriteLine(cars[0]); //Returns Volvo
            cars[0] = "Ferrari"; //Replace Volvo with Ferrari at index 0
            Console.WriteLine(cars[0]); //Returns Ferrari
            Console.WriteLine(cars.Length); //Returns length of cars array

            //Other way to create an array
            string[] f1Teams = new string[5] { "Mercedes", "Red Bull", "McLaren", "Renault", "Racing Point"}; //Requires 5 elements
        }

        private static void _Loops()
        {
           //While
            int x = 0;
            while (x != 27) //Run until x not equals to 27
            {
                Console.WriteLine(x);
                x++;
            }

           //Do-While
            int y = 0;
            do //Logic first
            {
                Console.WriteLine(y);
                y++;
            }
            while (y != 27); //Run until in the backyard while x not equals to 27

           //For Loop
            /*
             Syntax for (statement 1; statement 2; statement 3)
             {
                code block to be executed
             }
            */
            for (int i = 0; i <= 10; i++) //Iterating over given intervall
            {
                Console.WriteLine(i); //Prints out numbers between 0..10
            }

            //Foreach
            string[] cars = { "Volvo", "BMW", "Ford", "Renault" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }

        //Void method with parameter
        public static void myName(string name)
        {
            Console.WriteLine($"My name is: {name}"); //Prints out My name is: Bob
        }

        //Int method with two parameters
        public static int add(int x, int y)
        {
            return x + y; //Will return the sum of x and y
        }
    }
}
