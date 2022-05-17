using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaTempo
{
    class ColetaDados : ISubject
    {
        public double Temperatura { get; private set; }
        public double Umidade { get; private set; }

        /*private TelaExibeAtual telaExibeAtual = new TelaExibeAtual();
        private TelaExibeEstatistica telaExibeEstatistica = new TelaExibeEstatistica();*/

       //privado pois ngm sabe quem é o assinante
       private List<IObservables> observables = new List<IObservables>();

        //adiciona os seeds
        private Random rand = new Random();

        public bool getTemperaturaDoIOT()
        {
            //this.Temperatura = rand.Next(-10, 40);
            double novaTemperatura = rand.Next(-10, 40);
            if(novaTemperatura == this.Temperatura)
            {
                return false;
            }
            this.Temperatura = novaTemperatura;
            return true; 
        }

        public bool getUmidadeDoIOT()
        {
            //this.Umidade = rand.Next(0, 100); 
            double novaUmidade = rand.Next(0, 100);
            if (novaUmidade == this.Umidade)
            {
                return false;
            }
            this.Umidade = novaUmidade;
            return true;
        }

        public void avisaObservadores()
        { 
            foreach (IObservables observable in observables)
            {
                observable.Display(this.Temperatura, this.Umidade);
            }
        }

        public void adicionarObservador(IObservables observables)
        {
            this.observables.Add(observables);
        }

        public void removerObservador(IObservables observables)
        {
            this.observables.Remove(observables);
        }

        public void atualizaDados()
        {
            if(this.getUmidadeDoIOT() | this.getTemperaturaDoIOT())
            {
                this.avisaObservadores();
            }
        }

        /* public void AtualizaEAvisaAsTelas()
         {
             this.getTemperaturaDoIOT();
             this.getUmidadeDoIOT();

             foreach(IObservables observable in observables)
             {
                 observable.Display(this.Temperatura, this.Umidade);
             }

             /*telaExibeAtual.Display(this.Temperatura, this.Umidade);
             telaExibeEstatistica.Display(this.Temperatura, this.Umidade);
         }*/
    }
}
