using System;

namespace PadroesProjetoADA.Facade
{
    public class SistemaFilasAtendimento
    {
        public void SelecionarAtendimentos(string perfilAtendente)
        {
            Console.WriteLine($"Atendimentos Selecionados para o perfil: {perfilAtendente}");
        }

        public void OrdenarAtendimentos()
        {
            Console.WriteLine("Atendimentos Ordenados");
        }

        public void DisponibilizarAtendimentos()
        {
            Console.WriteLine("Atendimentos Disponibilizados");
        }
    }
}