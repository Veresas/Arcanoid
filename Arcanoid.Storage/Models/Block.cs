using Arcanoid.Contrats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arcanoid.Storage.Models
{
    internal class Block : Entites
    {
        public int Lenght { get; protected set; }
        public int Height { get; protected set; }
        public Block(Vector vector, int linght, int widht) 
        { 
            Position = vector;
            Lenght = linght;
            Height = widht;
        }
    }
}
