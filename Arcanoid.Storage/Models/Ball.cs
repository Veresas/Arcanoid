using Arcanoid.Contrats.Models;
using System.Windows;

namespace Arcanoid.Storage.Models
{
    /// <summary>
    /// Представление снаряда
    /// </summary>
    public class Ball : Entites
    {
        /// <summary>
        /// Размер шара
        /// </summary>
        public int Size { get; protected set; }

        /// <summary>
        /// Вектор движения снаряда
        /// </summary>
        public Vector MoveVector { get; set; } = new Vector(-1, -1);

        /// <summary>
        /// Заполнение всех полей
        /// </summary>
        /// <param name="size"></param>
        /// <param name="pos"></param>
        public Ball(int size, Vector pos)
        {
            Size = size;
            Position = pos;
        }
    }
}
