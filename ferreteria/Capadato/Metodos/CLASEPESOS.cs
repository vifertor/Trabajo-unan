using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capadato.Metodos
{
    public class CLASEPESOS
    {

        SqlCommand Command = new SqlCommand();
        Claseconexion conexion = new Claseconexion();

        public DataTable ListarPesos()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                DataTable dt = new DataTable();
                command.Connection = conexion.OpenConnection();
                command.CommandText = "sp_mostrarPesos";
                command.CommandType = CommandType.StoredProcedure;

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

        public bool InsertarPeso(string Name_Peso, float Libras, string Detalles_Peso)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ingresarPeso";
                command.Parameters.AddWithValue("@Name_Peso", Name_Peso);
                command.Parameters.AddWithValue("@Libras", Libras);
                command.Parameters.AddWithValue("@Detalles_Peso", Detalles_Peso);

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

        public bool ModificarPeso(int ID_Peso, string Name_Peso, float Libras, string Detalles_Peso)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_actualizarPeso";
                command.Parameters.AddWithValue("@ID_Peso", ID_Peso);
                command.Parameters.AddWithValue("@Name_Peso", Name_Peso);
                command.Parameters.AddWithValue("@Libras", Libras);
                command.Parameters.AddWithValue("@Detalles_Peso", Detalles_Peso);

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

        public bool EliminarPeso(int ID_Peso)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_eliminarPeso";
                command.Parameters.AddWithValue("@ID_Peso", ID_Peso);
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
