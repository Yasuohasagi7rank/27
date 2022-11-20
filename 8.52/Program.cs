using System;

namespace _8._52
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            for (int b = 0; b < 10; b++)
            {
                for (int c = 0; c < 20; c++)
                {
                    a = 100 - (b + c);
                    if (20 * b + 10 * c + a == 200)
                    {
                        Console.WriteLine("Телят " + a);
                        Console.WriteLine("Быков " + b);
                        Console.WriteLine("Коров " + c); 
                    }
                }
            }
        }
    }
}
