using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class SistemaSonido : IComponente
    {
        private IComponente decoramosA;

        public SistemaSonido(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return string.Format($"Radio 350XZ+\r\n {decoramosA.ToString()}");
        }
        public double Costo()
        {
            return decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Enciendo el radio";
        }
    }
}
