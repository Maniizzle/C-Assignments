using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double thesum = SumOfNumbers();
            Console.WriteLine("the sum of your numbers is {0}", thesum);
            Console.ReadKey();
        }

        static double SumOfNumbers()
        {

            double sum = 0;
            positiveInteger:
            Console.WriteLine("how many numbers do you want to add");
            int numOfIntegers = int.Parse(Console.ReadLine());
            if (numOfIntegers < 2)
            {
                Console.WriteLine("The least number you could sum is 2");
                goto positiveInteger;
            }
            Console.WriteLine("Input your Integer");
            restart:
            double newsum = double.Parse(Console.ReadLine());
            numOfIntegers--;
            sum = sum + newsum;
            if (numOfIntegers != 0)
            {
                Console.WriteLine("Input next integer");
                goto restart;
            }

            return sum;

        }
    }
}
