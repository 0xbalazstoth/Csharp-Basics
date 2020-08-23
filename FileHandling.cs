using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Requires for handling files

namespace Csharp_OOP
{
    class Colors
    {
        public string Color;

        public Colors(string color)
        {
            this.Color = color;
        }
    }

    class FileHandling
    {
        public static List<Colors> LstColors = new List<Colors>();
        static Colors Colors;

        public static void CreateFile(string fileName, string extension, params string[] colors)
        {
            FileStream fs = new FileStream($"{fileName}.{extension}", FileMode.Create); //Creating file
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8); //Calling fs and setting up an encoding
            for (int i = 0; i < colors.Length; i++)
            {
                sw.WriteLine(colors[i]);
                sw.Flush(); //Write if user exits
            }

            sw.Close(); //First close StreamWriter
            fs.Close(); //Then close FileStream

            Console.WriteLine($"File successfully created!"); //Message to user
        }

        public static List<Colors> ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream) //Reading until last line
            {
                string color = sr.ReadLine();
                Colors = new Colors(color);
                LstColors.Add(Colors);
            }
            sr.Close();
            return LstColors;
        }
    }
}
