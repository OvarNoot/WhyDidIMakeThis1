using System;

namespace BouncingDistance
{
    class WhydidImakethis
    {
        static void Main(string[] args)
        {
            while (true) // endless loop until you close it
            {
                LoopMethod();
            }
        }
        static double FindingBounces(double n, double nume, double deno, int lessthan)
        {
            double countdowns = 0;
            while (n > lessthan) //divides until it becomes lower than N foot you input with rebounds distance you input
            {
                n *= nume;
                n /= deno;
                countdowns++;
            }
            return countdowns;
        }
        static double FindingFeet(double k, double numer, double den)
        {
            double ogFeet = k;
            k *= numer;
            k /= den;
            k *= 2;
            k /= (1 - (numer / den));
            double result = Math.Ceiling(ogFeet + k); // rounds up the final result 

            return result;
        }
        static void LoopMethod()
        {
            // reads all the inputs from user
            Console.Write("Please enter height and then rebounds of the distance with numerator and denominator \nheight: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numerator: ");
            double nume = Convert.ToDouble(Console.ReadLine());
            Console.Write("Denominator: ");
            double deno = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many times will it bounce before its rebound is less than n foot? \nN: ");
            int timesless = Convert.ToInt32(Console.ReadLine());

            // writesout the output of count of bounces until the n value you typed
            double result = FindingBounces(height, nume, deno, timesless);
            Console.WriteLine("\nit will bound: " + result + " Times before it rebounces in less than" + timesless + "foot");

            // just writes out the distance it traveled
            double result2 = FindingFeet(height, nume, deno);
            Console.WriteLine("It traveled: " + result2 + " Feets long before it comes to rest on the ground \n");
        }
    }
}
