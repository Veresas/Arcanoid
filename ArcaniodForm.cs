using Arcanoid.Contrats.Models;
using Arcanoid.Manager;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arcanoid
{
    /// <summary>
    /// Окно вывода изображения игры
    /// </summary>
    public partial class ArcaniodForm : Form
    {
        private GameManager gameManager;
        private Graphics g;
        private Timer gameTimer;

        /// <summary>
        /// Принимает управляющий класс, инициализурет таймер
        /// </summary>
        /// <param name="gameManager"></param>
        public ArcaniodForm(GameManager gameManager)
        {
            this.gameManager = gameManager;
            InitializeComponent();
            Width = Constants.WidowsWidht;
            Height = Constants.WidowsHeight;
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
            g.DrawImage(gameManager.Draw(), 0, 0);
            gameManager.Move();
            if (!gameManager.CheakCollision())
            {
                gameTimer.Stop();
                MessageBox.Show("Вы проиграли");
                Close();
            }
            if (gameManager.IsWin())
            {
                gameTimer.Stop();
                MessageBox.Show("Вы победили");
                Close();
            }
        }

        private void ArcaniodForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                gameManager.ChangeDiractionPlyer(Direction.Left);
            }
            if (e.KeyCode == Keys.D)
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
