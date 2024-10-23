using System.Drawing;
using System.Windows;

namespace Arcanoid.Contrats.Models
{
    /// <summary>
    /// Базовый класс для всех сущностей в проекте
    /// </summary>
    public abstract class Entites
    {
        /// <summary>
        /// Позиция на экране
        /// </summary>
        public Vector Position { get; set; }

        /// <summary>
        /// Границы хитбокса
        /// </summary>
        public Rectangle Bounds { get; set; }
    }
}
