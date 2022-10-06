using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Observer2
{
    internal interface IObservable<T>
    {
        public void NotificarTodos();
        public void Registrar(IObserver<T> observer);
        public void Remover(IObserver<T> observer);
    }
}
