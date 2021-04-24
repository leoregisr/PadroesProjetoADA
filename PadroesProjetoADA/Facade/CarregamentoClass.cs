namespace PadroesProjetoADA.Facade
{
    public class CarregamentoClass
    {
        private readonly string _perfilUsuario;

        public CarregamentoClass(string perfilUsuario)
        {
            _perfilUsuario = perfilUsuario;
        }


        public void CarregarSistemas()
        {
            var sistemaGravacao = new SistemaGravacao();
            sistemaGravacao.CarregarSistema();
            sistemaGravacao.ChecarGravadores();
            sistemaGravacao.ChecarPortas();

            var sistemaTemporizador = new SistemaTemporizador();
            sistemaTemporizador.ChecarContadores();
            sistemaTemporizador.IniciarContadores();

            var sistemaFilasAtendimento = new SistemaFilasAtendimento();
            sistemaFilasAtendimento.SelecionarAtendimentos(_perfilUsuario);
            sistemaFilasAtendimento.OrdenarAtendimentos();
            sistemaFilasAtendimento.DisponibilizarAtendimentos();
        }
    }
}