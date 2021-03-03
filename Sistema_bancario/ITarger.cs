using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    interface ITarger
    {
        public void Apertura();
        public string Balance();
        public string Retiros();
        public string Consulta();
    }
}
