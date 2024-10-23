using Arcanoid.Manager;
using Arcanoid.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storedg = new GameStorage();
            var manedger = new GameManager(storedg);
            Application.Run(new ArcaniodForm(manedger));
        }
    }
}
