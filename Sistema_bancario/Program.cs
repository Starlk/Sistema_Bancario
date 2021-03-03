using System;

namespace Sistema_bancario
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a BankStarko");
            Console.WriteLine("Utilizara el app movil o el app Escritorio   [1] App movil   [2] app de escritorio  [3] Salir");
            int opcion = int.Parse(Console.ReadLine());
            FachadaBank fachada = new FachadaBank(opcion);


            Console.WriteLine("Desea Regresar? Si digite [s] No digite [n] ");
            string salir = Console.ReadLine();
            if (salir == "n" || salir=="N")
            {
                Console.WriteLine("Fin del programa");
            }
            else
            {
                Main(args);
            }
            Console.WriteLine();
            
        }
    }
}
