using System;

namespace NoridianFizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 101; ++i)
            {
                if (i % 14 == 0)
                {
                    Console.WriteLine("CrossShield");
                }

                if (i % 7 == 0)
                {
                    Console.WriteLine("Shield");
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine("Cross");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}

