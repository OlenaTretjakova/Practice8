using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(2,3);
            Console.WriteLine(fraction1.ToString());

            fraction1.SumFraction(2,3);

            Console.Write("Sum :");
            Console.WriteLine(fraction1.ToString());

            fraction1.DecreaseFraction(1, 3);
            Console.Write("Decrease fraction :");
            Console.WriteLine(fraction1.ToString());

            fraction1.Multiply(2, 2);
            Console.Write("Multiply fraction :");
            Console.WriteLine(fraction1.ToString());

            fraction1.Division(2, 1);
            Console.Write("Division fraction :");
            Console.WriteLine(fraction1.ToString());

            СomplexNumbers num1 = new СomplexNumbers(4, 5);
            num1.SumСomplexNumbers(2,4);

            Console.WriteLine(num1.ToString());

            num1.DecreaseСomplexNumbers(1, 7);

            Console.WriteLine(num1.ToString());

            DateTime date = new DateTime(1972, 12, 29);
            Birthday myBirthday = new Birthday(date);
            myBirthday.ToString();

            Console.WriteLine($"Birthday on:{myBirthday.GetDayOfWeek()}");

            Console.WriteLine($"Birthday in 2024 year on:{myBirthday.GetDayOfWeek(2024)}");


            Console.WriteLine($"Until the Birthday {myBirthday.DaysBeforBirthday()} days");



            Console.ReadLine();
        }
    }
}
