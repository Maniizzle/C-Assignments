using System;

    class GradingSystem
    {
        static void Main(string[] args)
        {
            Grade();
            Console.ReadLine();
        }
        static void Grade ()
        { Console.WriteLine("input your Name");
            string name = Console.ReadLine();
            Restart:
            Console.WriteLine("Input your grade in integer with a range of 1-100");
            bool success = int.TryParse(Console.ReadLine(), out int score);
            if (success)
            {
                if (score >= 0 && score < 101)
                 {
                    string grade = (score > 8 && score < 101) ? "A" : (score > 64 && score < 80) ? "AB" :
                    (score > 54 && score < 65) ? "B" : (score > 44 && score < 55) ? "C" : (score > 34 && score < 45) ? "CD" :
                    (score > 14 && score < 25) ? "E" : (score >= 0 && score < 14) ? "F" : "NOT IN RANGE OF 1-100";
                    Console.WriteLine("{0} grade is {1}", name, grade);
                }
                 else
                 { goto Restart; }
            }
            else
            {
            goto Restart;
            }
        }
    }
