using System;

namespace uppgift54
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "ödla", "Elliot", "Daniel", "Malin", "Tobias" };

            Array.Sort (namn);

            Console.WriteLine(namn[0]);
        }
    }
}