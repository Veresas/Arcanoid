using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Arcanoid.Contrats.Interfaces;
using Arcanoid.Contrats.Models;
using Arcanoid.Storage.Models;

namespace Arcanoid.Storage
{
    public class GameStorage : IGameStorage
    {
        public Block[,] blocks {  get; private set; }
        public Player player { get; private set; }
        public Ball ball { get; private set; }



        public GameStorage() 
        {
            player = new Player(Constants.LenghtPlayer, Constants.HeightPlayer,
                new Vector(Constants.WidowsWidht/2 - Constants.LenghtPlayer, Constants.WidowsHeight - 200), Constants.SpeedPlyer);
            ball = new Ball(Constants.SpeedBall, Constants.SizeBall, 
                new Vector(Constants.WidowsWidht / 2, Constants.WidowsHeight - 300));

            CreatBlocks();
        }

        public void CreatBlocks()
        {
            blocks = new Block[Constants.CountBlokcInColumn, Constants.CountBlokcInRow];
            var posX = Constants.BlockIndentation;
            var hight = Constants.HeightBlocks;
            var id = 0;
            for (int i = 0; i < Constants.CountBlokcInColumn; i++)
            {
                for (int j = 0; j < Constants.CountBlokcInRow; j++)
                {
                    blocks[i, j] = 
                        new Block(id++, new Vector(posX, hight),
                        Constants.LenghtBlocks, Constants.HeightBlocks);
                    posX += Constants.LenghtBlocks;
                }
                posX = Constants.BlockIndentation;
                hight += Constants.HeightBlocks;
            }
        }

        public void Delet(int x, int y)
        {
            blocks[x, y] = null;
        }

        public void MovePLayer(int i)
        {
            player.Position = new Vector( player.Position.X + i, player.Position.Y);
        }

        public void MoveBall()
        {
            ball.Position += ball.MoveVector * Constants.SpeedBall;
        }

    }
}

