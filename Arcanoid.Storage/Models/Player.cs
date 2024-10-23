using Arcanoid.Contrats.Models;
using System.Windows;

namespace Arcanoid.Storage.Models
{
    /// <summary>
    /// Представление платформы игрока
    /// </summary>
    public class Player : Entites
    {
        /// <summary>
        /// Направление движения платформы
        /// </summary>
        public Direction HorizontalDirection { get; set; } = Direction.InPlace;

        /// <summary>
        /// Длина платформы игрока
        /// </summary>
        public int Lenght { get; private set; }

        /// <summary>
        /// Высота платформы игрока
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Заполнение всех полей
        /// </summary>
        /// <param name="linght"></param>
        /// <param name="height"></param>
        /// <param name="pos"></param>
        public Player(int linght, int height, Vector pos)
        {
            Lenght = linght;
            Height = height;
            Position = pos;
        }
    }
}
