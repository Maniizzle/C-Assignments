using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string newWorld= Reverse("going");
            Console.WriteLine("The reverse is {0}", newWorld);
            Console.ReadLine();
        }
        static string Reverse(string word)
        {
            string revWord = "";
            int length = word.Length - 1;
            for (int i=length; i>=0; i--)
            {
                revWord = revWord + word[i]; 
            }
            return revWord;
        }
      

    }
}
