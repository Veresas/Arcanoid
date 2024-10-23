using System.Drawing;

namespace Arcanoid.Contrats
{
    public interface IGameManedger
    {
        /// <summary>
        /// Обработка движения всех подвижных элементов
        /// </summary>
        void Move();

        /// <summary>
        /// Проверка столкновения объектов
        /// </summary>
        /// <returns>false - столкновение с полом, true - в остальных случаях</returns>
        bool CheakCollision();

        /// <summary>
        /// Отрисовка кадров
        /// </summary>
        /// <returns></returns>
        Bitmap Draw();
    }
}
