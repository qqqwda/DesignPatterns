using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class Suspension : IComponente
    {
        private IComponente decoramosA;


        public Suspension(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public double Costo()
        {
            return decoramosA.Costo() + 63850;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + "Elevando suspensión";
        }

        public override string ToString()
        {
            return "Suspensión de alto desempeño \r\n" + decoramosA.ToString();
        }


    }
}
