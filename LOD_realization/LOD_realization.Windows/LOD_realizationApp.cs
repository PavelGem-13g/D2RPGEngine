using Stride.Engine;

namespace LOD_realization
{
    class LOD_realizationApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
