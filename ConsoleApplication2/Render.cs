using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Renderer
    {
        private Sprite thing = new Sprite(new Vector(10, 10), new Vector(1, 1));
        public void Render(TimeSpan gameTime, GameState state)
        {
            var buffer = GetBuffer(state.WorldSize);
            Paint(thing, buffer);
            thing.Move();
            Flush(buffer);
        }

        private void Paint(Sprite toPaint, char[,] buffer)
        {
            buffer[toPaint.Position.X, toPaint.Position.Y] = toPaint.Texture;
        }

        private char[,] GetBuffer(Vector size)
        {
            char[,] buffer = new char[size.X, size.Y];
            for (var i = 0; i < buffer.GetLength(0); i++)
            {
                for (var j = 0; j < buffer.GetLength(1); j++)
                {
                    buffer[i, j] = ' ';
                }
            }
            return buffer;
        }

        private void Flush(char[,] buffer)
        {
            Console.Clear();
            for(var i = 0; i < buffer.GetLength(0); i++)
            {
                StringBuilder thing = new StringBuilder();
                for(var j = 0; j < buffer.GetLength(1); j++)
                {
                    thing.Append(buffer[i, j]);
                }
                Console.Write(thing.ToString());
            }
        }
    }
}
