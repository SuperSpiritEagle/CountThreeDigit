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
            int numberN;
            int countSum = 0;

            Random random = new Random();

            numberN = random.Next(minNumber, maxNumber);
            Console.WriteLine(numberN);

            for (int i = numberN; i <endRange; i+=numberN)
            {
                if (i >= beginningRange)
                {
                    Console.WriteLine(i);
                    countSum++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Количество трехзначных кратных чисел числа: {numberN} = {countSum}");
        }
    }
}
