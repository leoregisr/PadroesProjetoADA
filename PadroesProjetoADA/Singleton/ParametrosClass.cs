using System;

namespace PadroesProjetoADA.Singleton
{
    public class ParametrosClass
    {
        public static ParametrosClass Instancia;
        private string _parametros;

        private ParametrosClass()
        {
            _parametros = Guid.NewGuid().ToString();
        }

        public static ParametrosClass GetParametros()
        {
            if (Instancia == null)
                Instancia = new ParametrosClass();

            return Instancia;
        }


        public void EscreverParametros()
        {
            Console.WriteLine($"Parametros: {_parametros}");
        }
    }
}