using System;

namespace Proj_Observer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observable meteorologia = new Observable(40);
            meteorologia.Registrar(new Observer("Lari", "lari@uol.com"));
            meteorologia.Registrar(new Observer("Pestana", "pestana@uol.com"));
            meteorologia.Registrar(new Observer("Thalya", "thalya@uol.com"));
            meteorologia.Registrar(new Observer("Artur", "artur@uol.com"));
            meteorologia.Registrar(new Observer("Baratão", "baratao@uol.com"));
            meteorologia.NotificarTodos();

            meteorologia.AlterarTemperatura(20);
            meteorologia.NotificarTodos();
            meteorologia.AlterarTemperatura(30);
            meteorologia.NotificarTodos();
        }
    }
}
