using System;

namespace OgreMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("You need inform your class name to map.");
                return;
            }

            if (string.IsNullOrEmpty(args[0]))
                Console.WriteLine("Class from empty");

            if (string.IsNullOrEmpty(args[1]))
                Console.WriteLine("Class to empty");

            string pathFileFrom = args[0];
            string pathFileTo = args[1];

            Console.WriteLine("File From: " + pathFileFrom + Environment.NewLine);
            Console.WriteLine("File To: " + pathFileTo + Environment.NewLine);
            
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}