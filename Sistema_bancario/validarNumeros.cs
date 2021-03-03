using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class validarNumeros
    {
        private int getnumero;
        private bool ciclo=false;
        public int getNumero(string mensaje)
        {
            do
            {
                try
                {
                    Console.WriteLine(mensaje);
                    string num = Console.ReadLine();
                    getnumero = int.Parse(num);
                    
                   
                }catch(Exception error)
                {
                    
                    Console.WriteLine("Debe digitar un numero entero!!", error.Message);
                }

            } while (ciclo == true);
            return getnumero;
        }
    
  

    }
}
