using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class TarjetaCredito
    {
        validarNumeros num = new validarNumeros();
        public void expendicion() {
            Console.WriteLine("Creando tarejta ......");
            string codigo = GenerarCodigo.codigo();
            int limite = 100000;
            Console.WriteLine("El numero de su tarjeta es " + codigo);
            string sql = $"insert into tarjeta_credito values('{codigo}',{limite},{0})";
            BD.Guardar(sql);
            Console.WriteLine("Cuenta Creada!!!!!! el limite de consumo es " + limite + "$ tiene un balance de  " + 0 +"$" );
        }
        public void consumo() {
            Console.WriteLine(" Ingrese el numero de la tarjeta ");
            string numTarjeta = Console.ReadLine();
           string num= BD.buscar(numTarjeta, "tarjeta_credito", "numTarjeta", "monto");
            if (int.Parse(num) <= 0)
            {
                Console.WriteLine("Usted no tiene balance para consumir !");
            }
            else
            {
                int consumo = this.num.getNumero("Ingrese el monto a consumir ");
                string sql = $"update tarjeta_credito set monto = {num} - {consumo} where numTarjeta = {numTarjeta} ";
                BD.Guardar(sql);
                Console.WriteLine("Balance era de {0}$",num);
                Console.WriteLine("Monto consumido {0}$",consumo);
                Console.WriteLine("Balance actual {0}$",int.Parse(num)-consumo);
            }
        }
        public void pagos() {
            Console.WriteLine(" Ingrese el numero de la tarjeta ");
            string numTarjeta = Console.ReadLine();
            string montoactual = BD.buscar(numTarjeta, "tarjeta_credito", "numTarjeta", "monto");
            int montoActual = int.Parse(montoactual);
            int valor = this.num.getNumero("Ingre el monto a pagar ");
            string sql = $"update tarjeta_credito set monto = {montoActual} + {valor} where numTarjeta = {numTarjeta} ";
            BD.Guardar(sql);
            Console.WriteLine("Transacion realizada correctamente!!!");
            Console.WriteLine($"Balance era de de {montoactual}$");
            Console.WriteLine($"Monto a pagar {valor}$");
            Console.WriteLine($"Balance actual es de {montoactual+valor}$");


        }
    }
}
