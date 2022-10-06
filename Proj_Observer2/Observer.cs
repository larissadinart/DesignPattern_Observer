using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Observer2
{
    public class Observer : IObserver<Double>
    {
        private String nome { get; set; }
        private String email { get; set; }
        private Double temperatura { get; set; }

        public Observer(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public void Atualizar(Double temperatura)
        {
            this.temperatura = temperatura;
            Console.WriteLine(nome + " temperatura alterada para " + temperatura + " enviando email para " + email);
        }
    }
}
