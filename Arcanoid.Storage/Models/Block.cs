using Arcanoid.Contrats.Models;
using System.Windows;

namespace Arcanoid.Storage.Models
{
    /// <summary>
    /// Представление блока
    /// </summary>
    public class Block : Entites
    {
        /// <summary>
        /// Длина блока
        /// </summary>
        public int Lenght { get; protected set; }

        /// <summary>
        /// Высота блока
        /// </summary>
        public int Height { get; protected set; }

        /// <summary>
        /// Заполнение всех переменных при создании, и создание хитбокса
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="linght"></param>
        /// <param name="widht"></param>
        public Block(Vector vector, int linght, int widht)
        {
            Position = vector;
            Lenght = linght;
            Height = widht;
            Bounds = new System.Drawing.Rectangle((int)vector.X, (int)vector.Y, Lenght, Height);
        }
    }
}
