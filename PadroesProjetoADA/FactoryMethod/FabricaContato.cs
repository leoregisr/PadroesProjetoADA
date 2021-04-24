namespace PadroesProjetoADA.FactoryMethod
{
    public class FabricaContato : ContatoIntF
    {
        public override Contato CriarContato(string tipoContato)
        {
            if (tipoContato == "SMS")
                return new ContatoSMS();
            else if (tipoContato == "Telefone")
                return new ContatoTelefone();
            else
                return new ContatoEmail();
        }
    }
}