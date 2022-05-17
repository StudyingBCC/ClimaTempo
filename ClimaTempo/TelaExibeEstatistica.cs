using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClimaTempo
{
    class TelaExibeEstatistica : IObservables
    {
        private List<double> Temperaturas = new List<double>();
        private List<double> Umidades = new List<double>();
        private ISubject Dados;

        public TelaExibeEstatistica(ISubject dados)
        {
            this.Dados = dados;
            this.Dados.adicionarObservador(this);
        }

        public void Display(double Temperatura, double Umidade)
        {
            this.Temperaturas.Add(Temperatura);
            this.Umidades.Add(Umidade);


            //isso aqui é possivel por conta do SYSTEM.LINQ (é um foreach abreviado kkkk)
            double maxT = Temperaturas.Max<double>();
            double minT = Temperaturas.Min<double>();

            double maxU = Umidades.Max<double>();
            double minU = Umidades.Min<double>();

            Console.WriteLine($"A temperatura maxima foi de {maxT}°C e a minima de {minT}°C");
            Console.WriteLine($"A umidade maxima foi de {maxU}, e a minima de {minU}%");
        }
    }
}
