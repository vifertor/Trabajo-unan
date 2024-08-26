using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capadato.Metodos
{
   public class CLASEDIAMETROS
    {

        SqlCommand Command = new SqlCommand();
        Claseconexion conexion = new Claseconexion();

        public DataTable ListarDiametros()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                DataTable dt = new DataTable();
                command.Connection = conexion.OpenConnection();
                command.CommandText = "sp_mostrarDiametros";
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

        public bool InsertarDiametro(string Name_Diametro)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ingresarDiametro";
                command.Parameters.AddWithValue("@Name_Diametro", Name_Diametro);

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

        public bool ModificarDiametro(int ID_Diametros, string Name_Diametro)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_actualizarDiametro";
                command.Parameters.AddWithValue("@ID_Diametros", ID_Diametros);
                command.Parameters.AddWithValue("@Name_Diametro", Name_Diametro);

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

        public bool EliminarDiametro(int ID_Diametros)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_eliminarDiametro";
                command.Parameters.AddWithValue("@ID_Diametros", ID_Diametros);
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
