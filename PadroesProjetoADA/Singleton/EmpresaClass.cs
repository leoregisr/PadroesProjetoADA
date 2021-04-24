using System;

namespace PadroesProjetoADA.Singleton
{
    public class EmpresaClass
    {
        public static EmpresaClass Instancia;
        private readonly string _idEmpresa;

        private EmpresaClass()
        {
            _idEmpresa = Guid.NewGuid().ToString();
        }

        public static EmpresaClass GetEmpresa()
        {
            if (Instancia == null)
                Instancia = new EmpresaClass();

            return Instancia;
        }

        public void EscreverIdEmpresa()
        {
            Console.WriteLine($"Id Empresa: {_idEmpresa}");
        }
    }
}