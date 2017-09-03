using System;

namespace DockerDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 55; i++)
            {
                Console.WriteLine($"Linea {i:00}");
                if (i == 45)
                {
                    Console.WriteLine("Breakpoint alcanzado en la línea 45");
                }
            }
        }
    }
}
