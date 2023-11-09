using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natural numbers using For loop");
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Even natural numbers using while loop");
            int j = 1;
            while(j<=20)
            {
                if (j%2==0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine("Odd Natural numbers using do while loop");
            int k = 1;
            do
            {
                if (k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            } while (k <= 20);
            Console.ReadKey();
        }
    }
}
