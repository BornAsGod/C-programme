using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            Console.Write("numbers:");
            int num = int.Parse(Console.ReadLine());
            for (int n = 1; n <= num; n++)
            {
                Console.Write("number{0}-",n);
                int b = int.Parse(Console.ReadLine());
                sum = sum + b;

            }

            Console.WriteLine("the sum is {0}",sum);
        }
    }
}