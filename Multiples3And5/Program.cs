using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiples of 3
            int sumOfThrees = 0;
            for (int i = 1; i < 1000; i++)
            {
                int multipleOfThree = i * 3;
                if (multipleOfThree < 1000)
                {
                    Console.WriteLine(multipleOfThree); //show multiples of 3
                    sumOfThrees += multipleOfThree;
                }
            }
            Console.WriteLine(sumOfThrees); //show sum of the multiples of 3

            //multiples of 5
            int sumOfFives = 0;
            for (int i = 1; i < 1000; i++)
            {
                int multipleOfFive = i * 5;
                if (multipleOfFive < 1000)
                {
                    Console.WriteLine(multipleOfFive); //show multiples of 5
                    sumOfFives += multipleOfFive;
                }
            }
            Console.WriteLine(sumOfFives); //show sum of the multiples of 5
        }
    }
}
