using System;
using static System.Console;
using static System.Threading.Thread;

namespace MultiThreadedPrinting
{
    public class Printer
    {
        // Lock token.
        private readonly object threadLock = new object();

        public void PrintNumbers()
        {
            lock (threadLock)
            {
                // Display Thread info.
                WriteLine($"-> {CurrentThread.Name} is executing PrintNumbers()");

                // Print out numbers.
                Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Sleep(100 * r.Next(5));
                    Write($"{i}, ");
                }
                WriteLine();
            }
        }
    }
}
