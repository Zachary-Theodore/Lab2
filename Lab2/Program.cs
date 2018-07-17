using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void contin()
        {
            Console.WriteLine("Continue? (y/n)");
            string UserInput = Console.ReadLine();
            if (UserInput.ToLower() == "y")
            {
                //fix this recursion
                Main();
            }
            else
            {
                //fix this hard stop
                return;
            }
        }

        static void Main()
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            //this program takes inputs and calculates both perimeters and areas.

            //input
            double lengthFeet;
            double lengthInches;
            double widthFeet;
            double widthInches;
            double heightFeet;
            double heightInches;
            //add in ability to put in inches and feet and convert.
            Console.WriteLine("Enter feet for the Length: ");
            lengthFeet = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for the Length: ");
            lengthInches = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter feet for the Width: ");
            widthFeet = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for the Width: ");
            widthInches = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter feet for the Height: ");
            heightFeet = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter inches for the Height: ");
            heightInches = double.Parse(Console.ReadLine());
           
            
            //solve problem
            double length = lengthFeet + (lengthInches / 12);
            //Console.WriteLine(length);
            double width = widthFeet + (widthInches / 12);
           // Console.WriteLine(width);
            double height = heightFeet + (heightInches / 12);
           // Console.WriteLine(height);

            double Area = length * width;
            //Console.WriteLine(Area);
            double Parimeter = 2 * length + 2 * width;
            //Console.WriteLine(Parimeter);
            double Volume = length * width * height;
           // Console.WriteLine(Volume);

            //Output

            Console.WriteLine($"Area: {Area - Area / 12}Feet, {Area%12*12}Inches.");
            Console.WriteLine($"Perimeter: {Parimeter - Parimeter / 12}Feet, {Parimeter%12*12}Inches.");
            Console.WriteLine($"Volume: {Volume - Volume / 12}Feet, {Volume%12*12}Inches.");
            contin();
        }


    }

}
  
