using System;

namespace Exercicio5Djalma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i, num;

            for (i = 1; i <= 100; i++)
            {
                num = i % 2;
                if (num == 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();
        }
    }
}
