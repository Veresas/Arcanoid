using Arcanoid.Contrats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arcanoid.Storage.Models
{
    internal class Ball : Entites
    {
        public int Speed { get; protected set; }
        public int Size { get; protected set; }
        public Direction HorizontalDirection { get; private set; } = Direction.Right;
        public Direction VerticalDirection { get; private set; } = Direction.Up;

        public Ball(int speed, int size, Vector pos)
        {
            Speed = speed;
            Size = size;
            Position = pos;
        }
    }
}
