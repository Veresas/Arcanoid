using Arcanoid.Contrats.Models;
using Arcanoid.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class ArcaniodForm : Form
    {
        private GameManager gameManager;
        private Graphics g;
        private Timer gameTimer;
        public ArcaniodForm(GameManager gameManager)
        {
            this.gameManager = gameManager;
            InitializeComponent();
            this.Width = Constants.WidowsWidht;
            this.Height = Constants.WidowsHeight;
            g = CreateGraphics();

           InitTimer();
        }

        private void InitTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            g.DrawImage(gameManager.Draw(), 0,0);
            gameManager.Move();
            if (!gameManager.CheakCollision())
            {
                gameTimer.Stop();
                MessageBox.Show("Вы проиграли");
                this.Close();
            }
            if (gameManager.IsWin())
            {
                gameTimer.Stop();
                MessageBox.Show("Вы победили");
                this.Close();
            }
        }

        private void ArcaniodForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                gameManager.ChangeDiractionPlyer(Direction.Left);
            }
            if(e.KeyCode == Keys.D)
            {
                gameManager.ChangeDiractionPlyer(Direction.Right);
            }
        }

        private void ArcaniodForm_KeyUp(object sender, KeyEventArgs e)
        {
            gameManager.ChangeDiractionPlyer(Direction.InPlace);
        }
    }
}
