using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class FachadaBank
    {
        cuenta_de_horro ch;
        prestamos p;
        CertificadoFinancierocs cf;
        Menus m;
        public FachadaBank(int num)
        {
            opcion = num;
            switch (opcion)
            {
                case 1:
                    inicioMovil();
                    break;
                case 2:
                    inicioEscritorio();
                    break;
                case 3:
                    Console.WriteLine("Gracias por elegirnos");
                    break;
                default:
                    Console.WriteLine("---Digitaste una opcion invalida--");
                    break;
            }
        }
        private int opcion;
       

        public void inicioEscritorio()
        {
             m = new Menus();
            Console.Clear();
            Console.WriteLine("-------------Version de escritorio de BankStarko-------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Digite el numero de su opcion");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("[1] ------- Abrir cuenta de ahorros ------------");
            Console.WriteLine("[2]----------Pedir prestamos--------------------");
            Console.WriteLine("[3]----------Tarjeta de Credito-----------------");
            Console.WriteLine("[4]-----------Certificado financiero-------------");
            Console.WriteLine("[5]-Salir");
            Console.WriteLine("-------------------------------------------------");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    m.MenuAhorro();
                    break;
                case 2:
                    m.MenuPrestamos();
                    break;
                case 3:
                    m.TarjetaCredito();
                    break;
                case 4:
                    m.certificadoFinanciero();
                    break;
                case 5:
                    Console.WriteLine("Gracias por elegirnos");
                    break;
                default:
                    Console.WriteLine("Opcion invalida-");
                    break;
            }
        }
        public void inicioMovil()
        {
            ch = new cuenta_de_horro();
            p = new prestamos();
            cf = new CertificadoFinancierocs();
            Console.Clear();
            Console.WriteLine("-------------------Version Movil-------------------");
            Console.WriteLine("--------Opciones---------");
            Console.WriteLine("[1] - Consultar balance de la cuenta de ahorro  ");
            Console.WriteLine("[2] - Pagar Prestamos ");
            Console.WriteLine("[3] - Consulta de interes del certificado financiero");
            Console.WriteLine("Salir");
            int valor = int.Parse(Console.ReadLine());
            switch (valor)
            {
                case 1:
                    Console.WriteLine("-----Balance----");
                    Console.WriteLine("Balance actual" + ch.Balance());
                    break;
                case 2:
                    Console.WriteLine("---Pagar prestamo----");
                    p.PagoPrestamo();
                    break;
                case 3:
                    Console.WriteLine("---Consulta de interes--");
                    cf.ConsultaInteres();
                    break;
                case 4:
                    Console.WriteLine("Gracias por elegirnos");
                    break;
                default:
                    Console.WriteLine("Valor ingresado fue invalido ");
                    break;
            }
        }

    }
}
