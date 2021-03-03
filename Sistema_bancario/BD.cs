using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;


namespace Sistema_bancario
{
    class BD
    {
        static string textCon = 
        "Data Source = C:/Users/USER/Desktop/ITLA/Quinto cuatrimeste/Programacion II/Sistema_bancario/Sistema_bancario/bancoBD.db; Version=3;New=False;Compress=True";
        static SQLiteConnection conexion = new SQLiteConnection(textCon); 

        static SQLiteCommand query;
        static SQLiteDataReader leer;
        ////static SQLiteTransaction transacion = conexion.BeginTransaction();
        static string text;



     public static void Guardar(string mensaje)
        {
            try
            {
                conexion.Open();
                query = new SQLiteCommand(mensaje,conexion);
                query.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {

                Console.WriteLine("Error de conexion " + error.Message);
            }
            finally
            {
                conexion.Close();
            }

        }
        public static void depositar(int monto, string numerCuenta)
        {
            try
            {
                conexion.Open();
                string data = $"UPDATE cuentaAhorro set montoIncial = {monto} + (SELECT montoIncial from cuentaAhorro where NumCuenta = '{numerCuenta}') where NumCuenta = '{numerCuenta}'";
                
                query = new SQLiteCommand(data, conexion);
                
              
                query.ExecuteNonQuery();
             

            }
            catch (Exception error)
            {

                Console.WriteLine("Error de conexion " + error.Message);
            }
            finally
            {
                conexion.Close();
            }
           
            
        }
        public static string buscar(string numerocuenta, string tabla, string campo,string campoSel) {
            try
            {
                string data = $"SELECT {campoSel} from {tabla} where {campo} ='{numerocuenta}'";

                conexion.Open();
                query = new SQLiteCommand(data, conexion);
                
                leer = query.ExecuteReader();
                if (leer.Read())
                {
                    text = Convert.ToString(leer[0]);
                }
               
            }
            catch (Exception error)
            {

                Console.WriteLine("Error de conexion " + error.Message);
            }
            finally
            {
                conexion.Close();
            }
            return text;
        }
        
    }
}
