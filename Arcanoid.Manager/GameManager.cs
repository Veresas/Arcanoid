using Arcanoid.Contrats;
using Arcanoid.Contrats.Interfaces;
using Arcanoid.Contrats.Models;
using Arcanoid.Manager.Properties;
using Arcanoid.Storage;
using Arcanoid.Storage.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Arcanoid.Manager
{
    public class GameManager : IGameManedger
    {
        GameStorage gameStorage;
        public GameManager(GameStorage gameStorage)
        {
            this.gameStorage = gameStorage;
        }
        public bool CheakCollision()
        {
            UpdateHitbox();

            var b = gameStorage.ball;
            var pl = gameStorage.player;
            if (b.Bounds.Left < 0 || b.Bounds.Right > Constants.WidowsWidht)
            {
                b.MoveVector = new Vector(b.MoveVector.X * -1, b.MoveVector.Y);
            }
            
            if(b.Position.Y < 0)
            {
                b.MoveVector = new Vector(b.MoveVector.X, b.MoveVector.Y * -1);
            }

            if (b.Bounds.IntersectsWith(gameStorage.player.Bounds))
            {
                b.MoveVector = new Vector(b.MoveVector.X, b.MoveVector.Y * -1);
                b.Position = new Vector(b.Position.X, b.Position.Y - 10);
            }

            if (b.Position.Y > Constants.WidowsHeight)
            {
                b.MoveVector = new Vector(b.MoveVector.X, b.MoveVector.Y * -1);
                return false;
            }
            
            foreach (var s in gameStorage.blocks)
            {
                if (s != null)
                {
                    if (b.Bounds.IntersectsWith(s.Bounds))
                    {
                        b.MoveVector = new Vector(b.MoveVector.X, b.MoveVector.Y * -1);
                        gameStorage.Delet(s);
                        return true;
                    }
                }
            }

            return true;
        }

        public Bitmap Draw()
        {
            var newImg = new Bitmap(Constants.WidowsWidht, Constants.WidowsHeight);
            var gr = Graphics.FromImage(newImg);
            gr.Clear(Color.Green);
            foreach (var s in gameStorage.blocks)
            {
                if (s != null)
                {
                    gr.DrawImage(Resources.block, new Rectangle(Convert.ToInt32(s.Position.X), Convert.ToInt32(s.Position.Y), s.Lenght, s.Height));

                }
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

        public void ChangeDiractionPlyer(Direction direction)
        {
            gameStorage.player.HorizontalDirection = direction;
        }

        private void UpdateHitbox()
        {
            var pl = gameStorage.player;
            var b = gameStorage.ball;
            pl.Bounds = new Rectangle((int)pl.Position.X, (int)pl.Position.Y, pl.Lenght, pl.Height);
            b.Bounds = new Rectangle((int)b.Position.X,(int)b.Position.Y, b.Size, b.Size);
        }

        public bool IsWin()
        {
            foreach (var blok in gameStorage.blocks)
            {
                if(blok != null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
