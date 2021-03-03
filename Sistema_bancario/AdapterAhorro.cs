using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class AdapterAhorro : ITarger
    {
        SuperAhorro cuentaS;
       public void Apertura()
        {
            throw new NotImplementedException();
        }

        public string Balance()
        {
            return null;
        }

        public  string Consulta()
        {
            return null;
        }

       public  string Retiros()
        {
            cuentaS = new  SuperAhorro();
            Console.WriteLine("Ingrese el numero de cuenta ");
            string numero = Console.ReadLine();
            Console.WriteLine("Ingrese el monto que desea retirar !");
            int monto = int.Parse(Console.ReadLine());
            int nuevoB = cuentaS.ValidarRetiro(monto, numero);
            if (nuevoB>0)
            {

                return nuevoB +"";
            }
            else
            {
                return "El retiro es mayor al 40% del balance, no es admitido por el banco";
            }
        }
    }
}
