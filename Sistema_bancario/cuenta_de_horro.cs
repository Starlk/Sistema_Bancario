using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class cuenta_de_horro : ITarger
    {
        private string NumCuenta;
        private int MontoIncial;
        private int balance=0;
        validarNumeros num = new validarNumeros();
        public void Apertura()
        {
            NumCuenta = GenerarCodigo.codigo();
            MontoIncial = num.getNumero("Ingrese el monto incial de la cuenta ");
            String consulta = $"insert into cuentaAhorro values ('{NumCuenta}',{MontoIncial}) ";
            BD.Guardar(consulta);
            Console.WriteLine("TU numero de cuenta es " + NumCuenta);
            Console.WriteLine(" Cuenta creada!!!!!!!!!!");
            Console.ReadKey();
        }
        public string Balance()
        {
            Console.WriteLine("Ingrese el numero de cuenta ");
            string numero = Console.ReadLine();
            int valor = num.getNumero("Ingrese el moto a depositar ");
            ///BD.abrir();
            BD.depositar(valor, numero);
            string text=BD.buscar(numero, "cuentaAhorro", "NumCuenta", "montoIncial");
           
            ///BD.cerrar();
            return text;
        }
        public string Retiros()
        {

            Console.WriteLine("Ingrese el numero de cuenta ");
            string numero = Console.ReadLine();
            int valor = num.getNumero("Ingrese el moto a Retirar ");
            
            BD.depositar((valor * -1), numero);
            string text = BD.buscar(numero, "cuentaAhorro", "NumCuenta", "montoIncial");

            return text;
        }
        public string Consulta()
        {
            Console.WriteLine("Ingrese el numero de cuenta ");
            string numero = Console.ReadLine();
            string text = BD.buscar(numero, "cuentaAhorro", "NumCuenta", "montoIncial");
            return text;
        }

    }
           
    }

