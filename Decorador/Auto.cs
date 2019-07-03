using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class Auto : IComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public Auto(string pModelo, string pCaract, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaract;
            costo = pCosto;

        }

        public void Puertas(bool pEstado)
        {
            if (pEstado)
            {
                Console.WriteLine("Puertas cerradas");
            }
            Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format($"Modelo {modelo}, {caracteristicas} \r\n");
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendí motor";
        }
    }
}
