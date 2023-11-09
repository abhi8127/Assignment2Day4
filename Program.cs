using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num =int.Parse(Console.ReadLine());
            for(int k = 0; k <= num; k++)
            {
                if (num > 0)
                {
                    Console.WriteLine(k);
                    
                }
                else
                {
                    Console.WriteLine("You Have enterd the wrong input");
                }
            }
            Console.WriteLine("Even natural number");

            int num1 = 2;
            int i = 0;

            while (i <= 10)
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine(num1);
                    num1++;
                    i++;
                }
                else
                {
                    num1++;
                }
            }

            Console.WriteLine("Do while loop 10 odd natural no");

            int num2 = 1;
            int j = 0;
            do
            {
                if (num2 % 2 != 0)
                {
                    Console.WriteLine(num2);
                    num2++;
                    j++;
                }
                else
                {
                    num2++;
                }
            }
            while (j <= 10);
            {

            }
            Console.ReadKey();
        }
    }
}
