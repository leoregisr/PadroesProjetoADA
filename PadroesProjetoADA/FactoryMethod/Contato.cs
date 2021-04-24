using System;

namespace PadroesProjetoADA.FactoryMethod
{
    public abstract class Contato
    {
        public void IniciarContato()
        {
            Console.WriteLine($"Iniciando Contato do tipo: {this.GetType()}");
        }
    }
}