using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid.Contrats.Interfaces
{
    public interface IGameStorage
    {
        void MovePLayer(int i);
        void MoveBall();
        void Delet(int a, int b);
        void CreatBlocks(int x,int y);
    }
}
