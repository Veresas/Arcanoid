namespace Arcanoid.Contrats.Models
{
    /// <summary>
    /// Все коснтанты проекта
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Длина блоков
        /// </summary>
        public static int LenghtBlocks { get; private set; } = 70;
        
        /// <summary>
        /// Высота блоков
        /// </summary>
        public static int HeightBlocks { get; private set; } = 30;
        
        /// <summary>
        /// Высота платформы игрока
        /// </summary>
        public static int HeightPlayer { get; private set; } = 20;
        
        /// <summary>
        /// Длинна платформы игрока
        /// </summary>
        public static int LenghtPlayer { get; private set; } = 90;
        
        /// <summary>
        /// Скорость движения платформы игрока
        /// </summary>
        public static int SpeedPlyer { get; private set; } = 3;
        
        /// <summary>
        /// Скорость движения снаряда
        /// </summary>
        public static int SpeedBall { get; private set; } = 5;
        
        /// <summary>
        /// Размер снаряда
        /// </summary>
        public static int SizeBall { get; private set; } = 20;
        
        /// <summary>
        /// Отступ блоков от края экрана
        /// </summary>
        public static int BlockIndentation { get; private set; } = 10;
        
        /// <summary>
        /// Высота окна формы
        /// </summary>
        public static int WidowsHeight { get; private set; } = 600;
        
        /// <summary>
        /// Ширина окна формы
        /// </summary>
        public static int WidowsWidht { get; private set; } = 400;
        
        /// <summary>
        /// Число блоков в колонне/ число строк
        /// </summary>
        public static int CountBlokcInColumn { get; private set; } = 3;

        /// <summary>
        /// Число блоков в строке/ число коллон
        /// </summary>
        public static int CountBlokcInRow { get; private set; } = 5;

    }
    
}
