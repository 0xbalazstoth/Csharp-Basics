using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_OOP
{
    //Car class with properties
    class Vehicle
    {
        public string Brand;
        public string Color;
        public int HorsePower;
        public bool isItFast;
        public DateTime ReleasedIn = new DateTime(2003, 11, 23); //Default value
    }

    #region Inheritance
    class Car : Vehicle
    {
        public string Type = "Sportcar";
        public int WeightInTons = 1;
    }
    #endregion

    #region Constructor
    class Dessert
    {
        public string Cake;

        //This is the Constructor
        public Dessert(string cake)
        {
            this.Cake = cake;
        }
    }
    #endregion

    #region Properties
    class Resolution
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    #endregion

    #region Polymorphism
    class Sport
    {
        public virtual void sport()
        {
            Console.WriteLine("What is your favorite sport?");
        }
    }

    class Football : Sport
    {
        public override void sport()
        {
            Console.WriteLine("Mine is football");
        }
    }

    class Golf : Sport
    {
        public override void sport()
        {
            Console.WriteLine("Mine is golf");
        }
    }
    #endregion

    #region Interface
    interface Animal
    {
        void AnimalSound();
    }

    class Pig : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    #endregion

    #region Enum
    enum Languages
    { 
        Hungarian,
        German,
        English
    }

    enum Weekdays
    { 
        Monday, //1
        Tuesday, //2
        Wednesday, //3
        Thursday, //4
        Friday, //5
        Saturday, //6
        Sunday //7
    }
    #endregion

    class OOP
    {
        static void Main(string[] args)
        {
            //Creating object of Car class
            Car myCar = new Car();
            myCar.Brand = "Renault";
            myCar.Color = "Light grey";
            myCar.HorsePower = 1200;
            myCar.isItFast = true;
            Console.WriteLine($"Brand: {myCar.Brand}, Color: {myCar.Color}, HorsePower: {myCar.HorsePower}, Is it fast? {myCar.isItFast}, Released in: {myCar.ReleasedIn.Year}, Type: {myCar.Type}, Weight: {myCar.WeightInTons}");

            Dessert dessert = new Dessert("Chocolate");
            Console.WriteLine(dessert.Cake);

            Resolution res = new Resolution();
            res.Width = 1920;
            res.Height = 1080;
            Console.WriteLine($"My monitor's resolution is: Width: {res.Width}px, Width: {res.Height}px");

            //Access Modifiers
            //public: The code is accessible for all classes
            //private: The code is only accessible within the same class
            //protected: The code is accessible within the same class, or in a class that is inherited from that class.
            //internal: The code is only accessible within its own assembly, but not from another assembly.

            Sport sport = new Sport();
            Sport football = new Football();
            Sport golf = new Golf();
            sport.sport();
            football.sport();
            golf.sport();

            Pig pig = new Pig();
            pig.AnimalSound();

            Console.WriteLine($"My prior language is: {Languages.Hungarian}");

            int weekdays = (int)Weekdays.Friday + 1;
            Console.WriteLine(weekdays);

            FileHandling.CreateFile("colors", "txt", "grey", "black", "blue", "green");
            FileHandling.ReadFile("colors.txt");
            var LstColors = FileHandling.LstColors;
            for (int i = 0; i < LstColors.Count; i++)
            {
                Console.WriteLine(LstColors[i].Color);
            }

            Person person = new Person();
            person.Detail("Bob");
            person.Detail(""); //Will throw an error, because name is empty.

            Console.ReadKey();
        }
    }
}
