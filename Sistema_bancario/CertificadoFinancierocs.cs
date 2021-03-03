using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_bancario
{
    class CertificadoFinancierocs
    {
        public void Apertura()
        {
            validarNumeros num = new validarNumeros();
            string numCertificado = GenerarCodigo.codigo();
            int monto = num.getNumero(" Ingrese el monto del certificado financiero ");
            int dias = num.getNumero("Ingrese el plazo  de duracion de su certificado ");
            string sql = $"insert into Certificado values ('{numCertificado}',{monto},{dias})";
            BD.Guardar(sql);
            Console.WriteLine("El codgio de su certificado es  : " + numCertificado);
        }
        public void ConsultaInteres()
        {
            Console.WriteLine("Ingrese el codigo de su certificado ");
            string codigo = Console.ReadLine();
            string monto = BD.buscar(codigo, "Certificado", "numCertificado", "monto");
            string dias = BD.buscar(codigo, "Certificado", "numCertificado", "dias");
            int Monto = int.Parse(monto);
            int Dias = int.Parse(dias);
            double interes = Monto * Math.Pow(1 + (10 / 100), (Dias / 12) - 1);
            Console.WriteLine(" Consulta de interes " + interes );
        }
    }
    }

