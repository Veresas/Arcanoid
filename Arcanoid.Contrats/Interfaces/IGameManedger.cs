using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid.Contrats
{
    public interface IGameManedger
    {
        void Move();
        void CreatBlocks(int x, int y);
        void CheakCollision();
        Bitmap Draw();

    }
}
