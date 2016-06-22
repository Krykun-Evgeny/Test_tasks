using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("List of divisors: ");
            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
