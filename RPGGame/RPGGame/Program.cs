using System;
using Project.Engine;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to continue");
            while (Console.ReadKey().Key==ConsoleKey.Enter)
            {
                Scene scene = new Scene();
                scene.Init();
                scene.Pipeline();  
                Console.WriteLine("Press Enter to continue");
            }
        }
    }
}