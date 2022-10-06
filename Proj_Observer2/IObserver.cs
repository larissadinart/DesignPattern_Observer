using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Observer2
{
    public interface IObserver<T>
    {
        public void Atualizar(T t);
    }
}
