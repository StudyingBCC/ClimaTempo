using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaTempo
{
    interface ISubject
    {
        public void adicionarObservador(IObservables observables);
        public void removerObservador(IObservables observables);
        public void avisaObservadores(); 
    }
}
