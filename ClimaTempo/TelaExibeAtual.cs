using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaTempo
{
    class TelaExibeAtual : IObservables
    {
        private ISubject Dado;

        public TelaExibeAtual(ISubject dado)
        {
            this.Dado = dado;
            this.Dado.adicionarObservador(this);
        }
        public void Display(double Temperatura, double Umidade)
        {
            Console.WriteLine($"A temperatura é de: {Temperatura}°C e a umidade de: {Umidade}%");
        }
    }
}
 