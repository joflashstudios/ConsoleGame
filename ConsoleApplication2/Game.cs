using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Game
    {
        ConsoleKeyInfo GetInput()
        {
            if (Console.KeyAvailable)
            {
                return Console.ReadKey();
            }
            return new ConsoleKeyInfo();
        }

        public void Run()
        {
            FrameTimer timer = new FrameTimer();
            Renderer renderer = new Renderer();
            GameState state = new GameState(Console.WindowHeight - 1, Console.BufferWidth);

            while (true)
            {
                TimeSpan frameTime = timer.GetFrametime();
                renderer.Render(frameTime, state);
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
