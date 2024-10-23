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

            CreatBlocks(3, 5);
        }

        public void CreatBlocks(int x, int y)
        {
            blocks = new Block[x, y];
            var posX = Constants.BlockIndentation;
            var hight = Constants.HeightBlocks;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    blocks[i, j] = 
                        new Block(new Vector(posX, hight),
                        Constants.LenghtBlocks, Constants.HeightBlocks);
                    posX += Constants.LenghtBlocks;
                }
                posX = Constants.BlockIndentation;
                hight += Constants.HeightBlocks;
            }
        }

        public void Delet(int a, int b)
        {
            blocks[a, b] = null;
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

