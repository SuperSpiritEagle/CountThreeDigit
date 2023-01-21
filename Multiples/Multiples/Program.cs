using System;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 28;
            int beginningRange = 100;
            int endRange = 1000;
            int n;
            int countThreeDigit = 0;

            Random random = new Random();

            n = random.Next(minNumber, maxNumber);
            Console.WriteLine(n);

            for (int i = n; i <endRange; i+=n)
            {
                if (i >= beginningRange)
                {
                    Console.WriteLine(i);
                    countThreeDigit++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Количество трехзначных кратных чисел числа: {n} = {countThreeDigit}");
        }
    }
}
