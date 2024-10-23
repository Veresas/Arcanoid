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
        private Block[,] blocks;
        private Player player;
        private Ball ball;

        GameStorage() 
        {
            player = new Player(Constants.LenghtPlayer, Constants.HeightPlayer,
                new Vector(Constants.WidowsWidht/2, Constants.HeightPlayer - 10), Constants.SpeedPlyer);
            ball = new Ball(Constants.SpeedBall, Constants.SizeBall, 
                new Vector(Constants.WidowsWidht / 2, Constants.HeightPlayer - 100));
        }

        public void CreatBlocks(int x, int y)
        {
            blocks = new Block[x, y];
            blocks[0, 0] = new Block(new Vector(0, 0), Constants.LenghtBlocks, Constants.HeightBlocks);
            var Hight = blocks[0, 0].Position.Y;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    blocks[i, j] = 
                        new Block(new Vector((blocks[i,j-1].Position.X+Constants.LenghtBlocks), Hight),
                        Constants.LenghtBlocks, Constants.HeightBlocks);
                }
                Hight += Constants.HeightBlocks;
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

        public void MoveBall(int x, int y)
        {
            ball.Position = new Vector( ball.Position.X + x, ball.Position.Y + y );
        }

    }
}

