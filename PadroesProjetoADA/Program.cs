using PadroesProjetoADA.Facade;
using PadroesProjetoADA.FactoryMethod;
using PadroesProjetoADA.Singleton;

namespace PadroesProjetoADA
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomeUsuario = args[0];
            var senha = args[1];

            var atendente = Usuario.Login(nomeUsuario, senha);

            //Facade
            if (atendente.IsLogado)
                CarregarSistemas(atendente);

            //Singleton
            ObterParametrosEmpresa();

            //Factory
            RealizarContatos();
        }

        private static void RealizarContatos()
        {
            var fabricaContato = new FabricaContato();
            var contatoSms = fabricaContato.CriarContato("SMS");
            var contatoEmail = fabricaContato.CriarContato("EMail");
            var contatoTelefone = fabricaContato.CriarContato("Telefone");

            contatoSms.IniciarContato();
            contatoEmail.IniciarContato();
            contatoTelefone.IniciarContato();
        }

        private static void ObterParametrosEmpresa()
        {
            var parametros = ParametrosClass.GetParametros();
            parametros.EscreverParametros();

            var empresa = EmpresaClass.GetEmpresa();
            empresa.EscreverIdEmpresa();

            parametros = ParametrosClass.GetParametros();
            parametros.EscreverParametros();

            empresa = EmpresaClass.GetEmpresa();
            empresa.EscreverIdEmpresa();
        }

        private static void CarregarSistemas(Usuario atendente)
        {
            var carregamento = new CarregamentoClass(atendente.NomePerfil);
            carregamento.CarregarSistemas();
        }
    }
}
