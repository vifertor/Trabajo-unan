using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capadato.Metodos
{
  public class CLASECATEGORIA
    {

        SqlDataReader LeerFilas;
        SqlCommand Command = new SqlCommand();

        Claseconexion conexion = new Claseconexion();

        public DataTable ListarCategoria()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                DataTable dt = new DataTable();
                command.Connection = conexion.OpenConnection();
                command.CommandText = "sp_mostrarCategorias";
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

        public bool InsertarCategoria(string Name_Categoria)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ingresarCategoria";
                command.Parameters.AddWithValue("@Name_Categoria", Name_Categoria);

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

        public bool ModificarCategoria(int ID_Categoria, string Name_Categoria)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_actualizarCategoria";
                command.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
                command.Parameters.AddWithValue("@Name_Categoria", Name_Categoria);

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

        public bool EliminarCategoria(int ID_Categoria)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_eliminarCategoria";
                command.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
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
