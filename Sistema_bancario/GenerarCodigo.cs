using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class GenerarCodigo
    {
        public static string codigo()
        {
            Random rd = new Random();
           
            string cod = $"{rd.Next(1000,9999)}-{rd.Next(1000,9999)}-{rd.Next(100,999)}";
            return cod;
        }
    }
}
