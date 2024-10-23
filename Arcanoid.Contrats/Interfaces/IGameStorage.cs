namespace Arcanoid.Contrats.Interfaces
{
    public interface IGameStorage
    {
        /// <summary>
        /// Движение платформы игрока в определенном направлении
        /// </summary>
        /// <param name="i"></param>
        void MovePLayer(int i);

        /// <summary>
        /// ОБновлении информации о положении шарика
        /// </summary>
        void MoveBall();
    }
}
