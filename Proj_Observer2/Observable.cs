using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Observer2
{
    public class Observable : IObserver<object>
    {
        private List<IObserver<Double>> observers = new();
        public Double Temperatura { get; set; }

        public Observable(Double temperatura)
        {
            this.Temperatura = temperatura;
        }

        public void AlterarTemperatura(Double temperatura)
        {
            this.Temperatura = temperatura;
        }

        public void NotificarTodos()
        {
            Console.WriteLine("Notificando");
            foreach (var observer in observers)
            {
                observer.Atualizar(Temperatura);
            }
            Console.WriteLine("--------------\n");
        }

        public void Registrar(IObserver<Double> observer)
        {
            observers.Add(observer);

        }

        public void Remover(IObserver<Double> observer)
        {
            observers.Remove(observer);
        }

        public void Atualizar(object t)
        {
            throw new NotImplementedException();
        }
    }
}
