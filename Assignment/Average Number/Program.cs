using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
             var avg= AverageNumber();
            Console.WriteLine("The average number of your numbers is {0}", avg);
            Console.ReadKey();

        } 

        static double AverageNumber()
        {

            double sum = 0;
        positiveInteger:
            Console.WriteLine("how many numbers do you want to find the average");
            int numOfIntegers = int.Parse(Console.ReadLine());
            int totalNumberOfIntegers = numOfIntegers;
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
            double Average = sum / totalNumberOfIntegers;
            if (numOfIntegers != 0)
            {
                Console.WriteLine("Input next integer");
                goto restart;
            }
            //Console.WriteLine(Average);
            return Average;

        }
    }
}
