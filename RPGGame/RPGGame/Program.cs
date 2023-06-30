using System;
using Project.Engine;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene();
            scene.Init();
            scene.Pipeline();
        }
    }
}