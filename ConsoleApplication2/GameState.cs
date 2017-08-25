using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class GameState
    {
        public Vector WorldSize { get; }
        public GameState(int sizeX, int sizeY)
        {
            WorldSize = new Vector(sizeX, sizeY);
        }
    }

    class Sprite
    {
        public char Texture { get; set; } = 'X';
        public Sprite(Vector position, Vector velocity)
        {
            Position = position;
            Velocity = velocity;
        }

        public void Move()
        {
            Position.X += Velocity.X;
            Position.Y += Velocity.Y;
        }

        public Vector Position { get; set; }
        public Vector Velocity { get; set; }
    }

    class Vector
    {
        public static readonly Vector Zero = new Vector(0, 0);
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
