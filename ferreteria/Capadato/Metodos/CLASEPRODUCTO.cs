using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capadato.Metodos
{
    public class CLASEPRODUCTO
    {

        SqlDataReader LeerFilas;
        SqlCommand Command = new SqlCommand();

        Claseconexion conexion = new Claseconexion();

        public DataTable ListarProducto()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                DataTable dt = new DataTable();
                command.Connection = conexion.OpenConnection();
                command.CommandText = "sp_mostrarProductos";
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
        public bool InsertarProducto(string Name_Producto)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ingresarProducto";
                command.Parameters.AddWithValue("@Name_Producto", Name_Producto);
           

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

        public bool ModificarProducto(int ID_Producto, string Name_Producto)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_actualizarProducto";
                command.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                command.Parameters.AddWithValue("@Name_Producto", Name_Producto);
            

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

        public bool EliminarProducto(int ID_Producto)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_eliminarProducto";
                command.Parameters.AddWithValue("@ID_Producto", ID_Producto);
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
