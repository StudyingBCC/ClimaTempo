using System;

namespace ClimaTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            ColetaDados Dados = new ColetaDados();
            TelaExibeAtual telaExibeAtual = new TelaExibeAtual(Dados);
            TelaExibeEstatistica telaExibeEstatistica = new TelaExibeEstatistica(Dados);

            Console.WriteLine("-----------------------");
            Dados.atualizaDados();
            Console.WriteLine("-----------------------");
            Dados.atualizaDados();
            Console.WriteLine("-----------------------");
            Dados.atualizaDados();
            Console.WriteLine("-----------------------");
            Dados.atualizaDados();
        }
    }
}
