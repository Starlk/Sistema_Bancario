using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class SuperAhorro
    {
       
        public int ValidarRetiro(int monto,string numero)
        {
            int Balance = int.Parse(BD.buscar(numero, "cuentaAhorro", "NumCuenta", "montoIncial"));
            if (monto <= (Balance * 0.40))
            {
                BD.depositar((monto * -1), numero);
                return (Balance-monto);
            }
            else
            {
                return 0;
            }
        }
    }
}
