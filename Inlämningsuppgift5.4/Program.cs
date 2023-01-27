using System;

namespace uppgift54
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Tina", "Olle", "Daniel", "Malin", "Tobias" };

            Array.Sort (namn);

            Console.WriteLine(namn[0]);
        }
    }
}