using Arcanoid.Contrats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arcanoid.Storage.Models
{
    public class Block : Entites
    {
        public int Id { get; set; }
        public int Lenght { get; protected set; }
        public int Height { get; protected set; }
        public Block(int id,Vector vector, int linght, int widht) 
        {
            Id = id;
            Position = vector;
            Lenght = linght;
            Height = widht;
            Bounds = new System.Drawing.Rectangle((int)vector.X, (int)vector.Y, Lenght, Height);
        }
    }
}
