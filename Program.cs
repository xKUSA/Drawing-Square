using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter length ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
