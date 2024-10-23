using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Arcanoid.Contrats.Models;

namespace Arcanoid.Storage.Models
{
    public class Player : Entites
    {
        public Direction HorizontalDirection { get; set; } = Direction.InPlace;
        public int Speed { get; private set; }
        public int Lenght { get; private set; }
        public int Height { get; private set; }

        public Player(int linght, int height, Vector pos, int speed)
        {
            Lenght = linght;
            Height = height;
            Position = pos;
            Speed = speed;
        }
    }
}
