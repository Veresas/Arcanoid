using Arcanoid.Contrats;
using Arcanoid.Contrats.Interfaces;
using Arcanoid.Contrats.Models;
using Arcanoid.Manager.Properties;
using Arcanoid.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid.Manager
{
    public class GameManager : IGameManedger
    {
        GameStorage gameStorage;

        public GameManager(GameStorage gameStorage)
        {
            this.gameStorage = gameStorage;
        }
        public void CheakCollision()
        {
            throw new NotImplementedException();
        }

        public void CreatBlocks(int x, int y)
        {
            gameStorage.CreatBlocks(x, y);
        }

        public Bitmap Draw()
        {
            var newImg = new Bitmap(Constants.WidowsWidht, Constants.WidowsHeight);
            var gr = Graphics.FromImage(newImg);
            gr.Clear(Color.Green);
            foreach (var s in gameStorage.blocks)
            {
                gr.DrawImage(Resources.block, new Rectangle(Convert.ToInt32(s.Position.X), Convert.ToInt32(s.Position.Y), s.Lenght, s.Height));
            }

            gr.DrawImage(Resources.player, new Rectangle(Convert.ToInt32(gameStorage.player.Position.X), Convert.ToInt32(gameStorage.player.Position.Y),
                gameStorage.player.Lenght, gameStorage.player.Height));
            gr.FillEllipse(Brushes.Blue, new Rectangle(Convert.ToInt32(gameStorage.ball.Position.X), Convert.ToInt32(gameStorage.ball.Position.Y),
                gameStorage.ball.Size, gameStorage.ball.Size));

            return newImg;
        }

        public void Move()
        {
            
            if (gameStorage.player.HorizontalDirection == Direction.Right)
            {
                gameStorage.MovePLayer(Constants.SpeedPlyer);
            } else if (gameStorage.player.HorizontalDirection == Direction.Left){

                gameStorage.MovePLayer(Constants.SpeedPlyer * -1);
            }

            gameStorage.MoveBall();
            
        }
    }
}
