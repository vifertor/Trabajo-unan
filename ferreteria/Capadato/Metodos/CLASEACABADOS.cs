using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capadato.Metodos
{
   public class CLASEACABADOS
    {

        SqlCommand Command = new SqlCommand();
        Claseconexion conexion = new Claseconexion();

        public DataTable ListarAcabados()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                DataTable dt = new DataTable();
                command.Connection = conexion.OpenConnection();
                command.CommandText = "sp_mostrarAcabados";
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                dt.Load(reader);

                conexion.CloseConnection();

                return dt;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarAcabado(string Name_Acabados)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ingresarAcabado";
                command.Parameters.AddWithValue("@Name_Acabados", Name_Acabados);

                command.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool ModificarAcabado(int ID_Acabado, string Name_Acabados)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_actualizarAcabado";
                command.Parameters.AddWithValue("@ID_Acabado", ID_Acabado);
                command.Parameters.AddWithValue("@Name_Acabados", Name_Acabados);

                command.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool EliminarAcabado(int ID_Acabado)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_eliminarAcabado";
                command.Parameters.AddWithValue("@ID_Acabado", ID_Acabado);
                command.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

    }
}
