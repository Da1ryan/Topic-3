using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Greetings
            string name;               
            int age;
            int currentYear;                                  
           
            Console.WriteLine("Hello, What is your name?");
            name = Console.ReadLine();                      
            Console.WriteLine("Could you please provide your current age.");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the current Year?.");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name}, You were born in {currentYear - age}.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Proceed.");
            Console.ReadLine();
            //Adder
            int int1;
            int int2;
            int int3;
           
            Console.WriteLine("Please state number 1.");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please state number 2.");
            int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please state number 3.");
            int3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your total of integers equals {int1+int2+int3}.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Proceed.");
            Console.ReadLine();
            //Distance
            double numKm1;
            double numKm2;
            double numKm3;

            Console.WriteLine("Please enter a distance in Km.");
            numKm1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second distance.");
            numKm2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a third distance.");
            numKm3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your average distance is {(numKm1+numKm2+numKm3)/3}.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Proceed.");
            Console.ReadLine();
            //Hypotenuse
            double rightTriLeg1;
            double rightTriLeg2;
            
            Console.WriteLine("Please enter a number for side of a of right triangle.");
            rightTriLeg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a number for the second side.");
            rightTriLeg2 = Convert.ToDouble(Console.ReadLine());
            double hypotenuse = Math.Sqrt(Math.Pow(rightTriLeg1, 2) + Math.Pow(rightTriLeg2, 2));
            Console.WriteLine($"The Hypotenuse of your right triangle is {hypotenuse}");
        }
    }
}
                                                                                                                           