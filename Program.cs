using System;

namespace Topic3keep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brandon Fraser ics4u
            string name;
            int age;
            int year;
            int born;
            int num1;
            int num2;
            int num3;
            int total;
            decimal km1 = 1.00m;
            decimal km2 = 1.00m;
            decimal km3 = 1.00m;
            decimal kmA = 1.00m;
            double leg1 = 1.00;
            double leg2 = 1.00;
            double hypo = 1.00;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What year is it?");
            year = Convert.ToInt32(Console.ReadLine());
            born = year - age;
            Console.WriteLine($"Hello {name}. The year you were born is {born}.");

            Console.WriteLine("Enter three numbers on separate lines.");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            total = num1 + num2 + num3;
            Console.WriteLine("The total is " + total + ".");

            Console.WriteLine("Enter three distances on separate lines.");
            km1 = Convert.ToDecimal(Console.ReadLine());
            km2 = Convert.ToDecimal(Console.ReadLine());
            km3 = Convert.ToDecimal(Console.ReadLine());
            kmA = (km1 + km2 + km3) / 3;
            Console.WriteLine("The averge is " + Math.Round(kmA, 2) + "km.");

            Console.WriteLine("Enter the length of leg one.");
            leg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of leg two.");
            leg2 = Convert.ToDouble(Console.ReadLine());
            hypo = (leg1 * leg1) + (leg2 * leg2);
            hypo = Math.Sqrt(hypo);
            Console.WriteLine("The length of the hypotenuse is " + Math.Round(hypo, 2));
        }
    }
}
