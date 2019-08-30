using System;

namespace RationalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create four Rational objects using 0, 1, and 2 arguments
            Rational r1 = new Rational(); // Using default arguments - Numberator = 0, Denominator = 1
            Rational r2 = new Rational(1); // Setting only the Numberator to 1 - Numerator = 1, Denominator = 1
            Rational r3 = new Rational(1, 2);
            Rational r4 = new Rational(2, 1);

            // Print the Rational objects listed above
            Console.WriteLine("  Four Rational objects(0, 1, 2)");
            Console.WriteLine("=================================");

            Console.WriteLine($"  Rational object r1: {r1}");
            Console.WriteLine($"  Rational object r2: {r2}");
            Console.WriteLine($"  Rational object r3: {r3}");
            Console.WriteLine($"  Rational object r4: {r4}");
            Console.WriteLine("=================================");

            // Extra Rational object for various outputs
            Rational r5 = new Rational(2, 3);
            Rational r6 = new Rational(3, 4);

            Console.WriteLine("\n  Extra two Rational objects");
            Console.WriteLine("=================================");
            Console.WriteLine($"  Rational object r5: {r5}");
            Console.WriteLine($"  Rational object r6: {r6}");
            Console.WriteLine("=================================");

            // Two additions
            Console.WriteLine("\n\n * Addition of two objects");
            Console.WriteLine("---------------------------------");

            Console.WriteLine(" Rational object r2 + r5:");
            Console.Write($" {r2} + {r5} = ");
            r2.IncreaseBy(r5);
            Console.WriteLine(r2);

            Console.WriteLine("\n Rational object r3 + r4:");
            Console.Write($" {r3} + {r4} = ");
            r3.IncreaseBy(r4);
            Console.WriteLine(r3);
            Console.WriteLine("---------------------------------");

            // Two subtractions
            Console.WriteLine("\n\n * Subtraction of two objects");
            Console.WriteLine("---------------------------------");

            Console.WriteLine(" Rational object r2 - r6:");
            Console.Write($" {r2} - {r6} = ");
            r2.DecreaseBy(r6);
            Console.WriteLine(r2);

            Console.WriteLine("\n Rational object r3 - r4:");
            Console.Write($" {r3} - {r4} = ");
            r3.DecreaseBy(r4);
            Console.WriteLine(r3);
            Console.WriteLine("---------------------------------");
        }
    }
}
