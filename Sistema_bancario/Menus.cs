using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class Menus
    {
        validarNumeros numero, opcion;
        CertificadoFinancierocs cf;
        TarjetaCredito tc;
        prestamos p;
        ITarger cuenta;
        public void MenuAhorro()
        {
            numero = new validarNumeros();   
            

            Console.WriteLine("-----------------Bienvenidos a bankStark---------------------");

            Console.Clear();
            Console.WriteLine("------Digite el numero de la cuenta de ahorro -----");
            Console.WriteLine("[1] --- Crear cuenta de ahorra ");
            Console.WriteLine("[2]------Depositar cuenta de ahorro");
            Console.WriteLine("[3]-------Retirar monto ");
            Console.WriteLine("[4]-------Consulta balance");
            Console.WriteLine("[5]----------Salir ");
            int num = numero.getNumero("Ingrese el numero de la opcion ");
            switch (num)
            {
                case 1:
                    cuenta = new cuenta_de_horro();
                    Console.WriteLine("----------------------Creando cuenta de ahorro---------------");
                    
                    cuenta.Apertura();
                    break;

                case 2:
                    cuenta = new cuenta_de_horro();
                    Console.WriteLine("-----------Depositando numero de cuenta---------------------------");
                    Console.WriteLine("Nuevo balance  " + cuenta.Balance());
                    break;
                case 3:

                    Console.WriteLine("[1] cuenta de ahorro [2] cuenta superAhorro");
                    int n = int.Parse(Console.ReadLine());
                    if (n==1)
                    {
                        cuenta = new cuenta_de_horro();
                        Console.WriteLine("Balance actual :"+cuenta.Retiros());
                    }
                    else if (n==2) 
                    {
                        cuenta = new AdapterAhorro();
                        Console.WriteLine("Balance actual :"+cuenta.Retiros());
                    }
                    else
                    {   
                        Console.WriteLine("Debe elegir un tipo de cuenta");
                    }
                    break;
                case 4:
                    cuenta = new cuenta_de_horro();
                    Console.WriteLine("-------------------Consultar balance de la cuenta------------");
                    Console.WriteLine("Balance de la cuenta actual  " + cuenta.Consulta());
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("--Gracias por elegirnos!!------");

                    break;
                default:
                    Console.WriteLine("Valor invalido intente de nuevo");
                    break;
            }
        }
        public void MenuPrestamos()
        {
            Console.Clear();
            Console.WriteLine("---------------Prestamos bancario -----------------");
            Console.WriteLine("[1] --  Solicitar prestamos ----- ");
            Console.WriteLine("[2] -- Pago de prestamos -----------");
            Console.WriteLine("[3]-salir");
            opcion = new validarNumeros();
            int num = opcion.getNumero(" Digite el numero de la opcion ");
            p = new prestamos(); 
            switch (num)
            {
                case 1:
                    p.Solicitud();
                    break;
                case 2:
                    p.PagoPrestamo();
                    break;
                case 3:
                    Console.WriteLine("Gracias por elegirnos");
                    break; 
                default:
                    Console.WriteLine("Opcion invalida----ERROR");
                    break;
            }
        }
        public void TarjetaCredito()
        {
            Console.Clear();
            Console.WriteLine("---------Tarjeta de Creditos------------");
            Console.WriteLine("[1] --------- Expendicion");
            Console.WriteLine("[2]-----------Consumos");
            Console.WriteLine("[3]-----------Pagos");
            Console.WriteLine("[4]----------Desea salir ");
            tc = new TarjetaCredito();
            opcion = new validarNumeros();
            int nume = opcion.getNumero(" ---Ingrese la opcion ");
            switch (nume)
            {
                case 1:
                    tc.expendicion();
                    break;
                case 2:
                    tc.consumo();
                    break;
                case 3:
                    tc.pagos();
                    break;
                case 4:
                    Console.WriteLine("Gracias por elegirnos ");
                        break;
                default:
                    Console.WriteLine("--------Valor invalido---");
                    break;
            }
        }
        public void certificadoFinanciero()
        {
            Console.Clear();
            Console.WriteLine("---------Certificado Financiero------------");
            Console.WriteLine("[1] --------- Apertura ");
            Console.WriteLine("[2]-----------Consulta de interes ");
            Console.WriteLine("[3]-Salir");
            cf = new CertificadoFinancierocs();
            opcion = new validarNumeros();
            int nume = opcion.getNumero(" ---Ingrese la opcion ");
            switch (nume)
            {
                case 1:
                    cf.Apertura();
                    break;
                case 2:
                    cf.ConsultaInteres();
                    break;
                case 3:
                    Console.WriteLine("Gracias por elegirnos");
                    break;
                default:
                    Console.WriteLine("--------Valor invalido---");
                    break;
            }
        }
    }
}
    
