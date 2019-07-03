using System;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente miAuto = new Auto("2018", "4 puertas", 20000);
            Console.WriteLine(miAuto);
            ((Auto)miAuto).Puertas(true);
            Console.WriteLine("------------------------");
            Console.ReadKey();

            //miAuto va a agregar nuevo sistema de sonido, con parámetros de miAuto
            miAuto = new SistemaSonido(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            
            Console.WriteLine("-----------------------");
            Console.ReadKey();

            miAuto = new Nitrogeno(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            //Usar algo propio del nitrógeno
            ((Nitrogeno)miAuto).UsaN();

            Console.WriteLine("----------------------");

            miAuto = new Suspension(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }
    }
}
