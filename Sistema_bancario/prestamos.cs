using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class prestamos
    {
        validarNumeros num = new validarNumeros();
        public void Solicitud()
        {
            
            string numPrestamo = GenerarCodigo.codigo();
            Console.WriteLine(" Ingrese el monto del prestao ");
            int numero = num.getNumero("-----Ingrese el monto del prestamo-------");
            int tasa = numero / 360;
            string sql= $"insert into prestamos values ('{numPrestamo}',{numero},{tasa})";
            Console.WriteLine($"El numero del prestamo {numPrestamo}, el monto del prestamos {numero} y la tasa de interes {tasa}");
            BD.Guardar(sql);
        }
        public void PagoPrestamo()
        {
            Console.WriteLine("Ingresa el codigo del prestamo--- ");
            string numPresta = Console.ReadLine();
            int monto = num.getNumero("    Ingrese al monto de pago -");
            string sql = $"update prestamos set monto = (select monto from prestamos where codPrestamo='{numPresta}') - {monto} ";
            BD.Guardar(sql);
            Console.WriteLine("Balance pendiente " + BD.buscar(numPresta, "prestamos", "codPrestamo","monto"));
        }
    }
}
