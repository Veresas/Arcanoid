using Arcanoid.Contrats.Interfaces;
using Arcanoid.Contrats.Models;
using Arcanoid.Storage.Models;
using System.Collections.Generic;
using System.Windows;

namespace Arcanoid.Storage
{
    /// <summary>
    /// Хранилище данных игры
    /// </summary>
    public class GameStorage : IGameStorage
    {
        /// <summary>
        /// Список блоков
        /// </summary>
        public List<Block> blocks {  get; private set; }

        /// <summary>
        /// Объект платформы игрока
        /// </summary>
        public Player player { get; private set; }

        /// <summary>
        /// Объект снаряда
        /// </summary>
        public Ball ball { get; private set; }


        /// <summary>
        /// Конструктор инициализирующий все переменные
        /// </summary>
        public GameStorage() 
        {
            player = new Player(Constants.LenghtPlayer, Constants.HeightPlayer,
                new Vector(Constants.WidowsWidht/2 - Constants.LenghtPlayer, Constants.WidowsHeight - 200));
            ball = new Ball(Constants.SizeBall, 
                new Vector(Constants.WidowsWidht / 2, Constants.WidowsHeight - 300));

            CreatBlocks();
        }

        private void CreatBlocks()
        {
            blocks = new List<Block>();

            var posX = Constants.BlockIndentation;
            var hight = Constants.HeightBlocks;
            for (int i = 0; i < Constants.CountBlokcInColumn; i++)
            {
                for (int j = 0; j < Constants.CountBlokcInRow; j++)
                {
                    blocks.Add(new Block( new Vector(posX, hight),
                        Constants.LenghtBlocks, Constants.HeightBlocks));
                    posX += Constants.LenghtBlocks;
                }
                posX = Constants.BlockIndentation;
                hight += Constants.HeightBlocks;
            }
        }

        /// <summary>
        /// Удаление блока из списка
        /// </summary>
        /// <param name="block"></param>
        public void Delet(Block block)
        {
            blocks.Remove(block);
        }

        /// <inheritdoc cref="IGameStorage"/>
        public void MovePLayer(int i)
        {
            player.Position = new Vector( player.Position.X + i, player.Position.Y);
        }

        /// <inheritdoc cref="IGameStorage"/>
        public void MoveBall()
        {
            ball.Position += ball.MoveVector * Constants.SpeedBall;
        }

    }
}

