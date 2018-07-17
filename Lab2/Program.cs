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
                Main();
            }
            else
            {
                return;
            }
        }

        static void Restart()
        {
            Console.WriteLine("Sorry, But you have entered a negative Number, The program will restart now.");
            Main();
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
            
            Console.WriteLine("Enter feet for the Length: ");
            lengthFeet = double.Parse(Console.ReadLine());
            if (lengthFeet < 0)
            {
                Restart();
            }

            Console.WriteLine("Enter inches for the Length: ");
            lengthInches = double.Parse(Console.ReadLine());
            if (lengthInches < 0)
            {
                Restart();
            }

            Console.WriteLine("Enter feet for the Width: ");
            widthFeet = double.Parse(Console.ReadLine());
            if (widthFeet < 0)
            {
                Restart();
            }

            Console.WriteLine("Enter inches for the Width: ");
            widthInches = double.Parse(Console.ReadLine());
            if (widthInches < 0)
            {
                Restart();
            }

            Console.WriteLine("Enter feet for the Height: ");
            heightFeet = double.Parse(Console.ReadLine());
            if (heightFeet < 0)
            {
                Restart();
            }

            Console.WriteLine("Enter inches for the Height: ");
            heightInches = double.Parse(Console.ReadLine());
            if (heightInches < 0)
            {
                Restart();
            }

            //solve problem
            double length = lengthFeet + (lengthInches / 12);
            double width = widthFeet + (widthInches / 12);
            double height = heightFeet + (heightInches / 12);

            double Area = length * width;
            double Parimeter = 2 * length + 2 * width;
            double Volume = length * width * height;
     
            int Area2 = Convert.ToInt32(Math.Floor(Area));
            int Parimeter2 = Convert.ToInt32(Math.Floor(Parimeter));
            int Volume2 = Convert.ToInt32(Math.Floor(Volume));
           
            //Output
            Console.WriteLine($"Area: {Area - (Area2-Area)*-1}Feet, {(Area-Area2)*12}Inches.");
            Console.WriteLine($"Perimeter: {Parimeter - (Parimeter2-Parimeter)*-1}Feet, {(Parimeter-Parimeter2)*12}Inches.");
            Console.WriteLine($"Volume: {Volume - (Volume2-Volume)*-1}Feet, {(Volume-Volume2)*12}Inches.");
            contin();
        }


    }

}
  
