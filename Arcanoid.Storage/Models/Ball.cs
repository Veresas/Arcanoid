using Arcanoid.Contrats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arcanoid.Storage.Models
{
    public class Ball : Entites
    {
        public float Speed { get; protected set; }
        public int Size { get; protected set; }
        public Vector MoveVector { get; set; }
        public Ball(int speed, int size, Vector pos)
        {
            Speed = speed;
            Size = size;
            Position = pos;
        }
    }
}
