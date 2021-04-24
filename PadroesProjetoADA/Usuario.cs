namespace PadroesProjetoADA
{
    public class Usuario
    {
        public string Nome { get; set; }

        public bool IsLogado { get; set; }

        public string NomePerfil { get; set; }

        public static Usuario Login(string usuario, string senha)
        {
            return new Usuario()
            {
                IsLogado = true,
                NomePerfil = "Perfil_Atendente"
            };
        }
    }
}