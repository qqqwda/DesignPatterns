using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> arbol = new Compuesto<string>("root");
            IComponente<string> trabajo = arbol;

            string opcion = "";
            string dato = "";

            while (opcion != "6")
            {
                Console.WriteLine($"Estoy en {trabajo.Nombre}");
                Console.WriteLine("1-Adicionar Compuesto");
                Console.WriteLine("2-Adicionar Componente");
                Console.WriteLine("3-Borrar");
                Console.WriteLine("4-Buscar");
                Console.WriteLine("5-Mostrar");
                Console.WriteLine("6-Salir");

                opcion = Console.ReadLine();

                Console.WriteLine("---------------------");

                if (opcion == "1")
                {
                    Console.WriteLine("Dame el nombre del compuesto: ");
                    dato = Console.ReadLine();

                    IComponente<string> c = new Compuesto<string>(dato);
                    trabajo.Adicionar(c);
                    trabajo = c;
                }

                if (opcion == "2")
                {
                    Console.WriteLine("Dame el nombre del componente: ");
                    dato = Console.ReadLine();

                    trabajo.Adicionar(new Componente<string>(dato));
                }

                if (opcion =="3")
                {
                    Console.WriteLine("dame el elemento a borrar: ");
                    dato = Console.ReadLine();

                    trabajo = trabajo.Borrar(dato);

                }

                if (opcion == "4")
                {
                    Console.WriteLine("Dame el Elemento a encontrar: ");
                    dato = Console.ReadLine();

                    trabajo = arbol.Buscar(dato);
                }

                if (opcion == "5")
                {
                    Console.WriteLine(arbol.Mostrar(0));
                }
            }
        }
    }
}
