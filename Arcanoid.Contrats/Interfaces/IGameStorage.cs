using Arcanoid.Contrats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid.Contrats.Interfaces
{
    public interface IGameStorage
    {
        void MovePLayer(int i);
        void MoveBall();
    }
}
