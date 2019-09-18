using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    class Program
    {
        public static void Main()
        {   
           Console.WriteLine( BaseToBase("1091120",10,2));
          
     
            Console.ReadLine();
            
        }

        static string BaseToBase(string Number, int TheNumbersBase, int TheNewBase)
        {
            int decimalNumber = Base
            ToDecimal(Number, TheNumbersBase);
            return DecimalToBase(decimalNumber, TheNewBase);
            
           
        }

        static string DecimalToBase(int decimalInput, int baseNumber)
        {
            string hexMap = "0123456789ABCDEF";
            string joinedNewNumber = "";
        Restart:
            if (decimalInput > 0)
            {
                int newNumber = decimalInput % baseNumber;
                decimalInput = decimalInput / baseNumber;
                char newNumberString = hexMap[newNumber];
                joinedNewNumber = newNumberString + joinedNewNumber;
            }

            else
            {
                return joinedNewNumber;
            }
            goto Restart;

        }


        static int BaseToDecimal(string inputNum, int theBase)
        {
            string newInput = inputNum.ToUpper();
            string hexMap = "0123456789ABCDEF";
            int decimalValue = 0;
            int power = inputNum.Length;

            for (int i = 0; i < inputNum.Length; i++)
            {
                string eachValue = newInput.Substring(i, 1);
                int Value = hexMap.IndexOf(eachValue);
                decimalValue += Value * (int)Math.Pow(theBase, power - 1);
                power--;
            }
            return decimalValue;
        }

    }

}

