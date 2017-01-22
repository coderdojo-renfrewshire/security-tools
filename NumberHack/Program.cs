using System;

namespace NumberHack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a number between: {int.MinValue} -> {int.MaxValue} ");

            var number = Convert.ToInt32(Console.ReadLine());

            for (var i = int.MinValue; i < int.MaxValue; i++)
            {
                if (number == i)
                {
                    Console.WriteLine($"Your number was {i} ... Use strong passwords!");
                } 
            }

            Console.ReadKey();
        }
    }
}
