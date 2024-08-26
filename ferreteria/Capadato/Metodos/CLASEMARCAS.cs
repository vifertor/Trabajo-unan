using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capadato.Metodos
{
    public class CLASEMARCAS
    {

        SqlCommand command = new SqlCommand();
        Claseconexion conexion = new Claseconexion();

     
        public DataTable ListarMarcas()
        {
            try
            {
                SqlDataReader reader;
                DataTable dt = new DataTable();
                command.Connection = conexion.OpenConnection();
                command.CommandText = "sp_mostrarMarcas";
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                dt.Load(reader);

                conexion.CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar marcas: " + ex.Message);
                return null;
            }
        }


        public bool InsertarMarca(string Name_Marca)
        {
            try
            {
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ingresarMarca";
                command.Parameters.AddWithValue("@Name_Marca", Name_Marca);

                command.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar marca: " + ex.Message);
                return false;
            }
        }

      
        public bool ModificarMarca(int ID_Marca, string Name_Marca)
        {
            try
            {
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_actualizarMarca";
                command.Parameters.AddWithValue("@ID_Marca", ID_Marca);
                command.Parameters.AddWithValue("@Name_Marca", Name_Marca);

                command.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar marca: " + ex.Message);
                return false;
            }
        }

    
        public bool EliminarMarca(int ID_Marca)
        {
            try
            {
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_eliminarMarca";
                command.Parameters.AddWithValue("@ID_Marca", ID_Marca);

                command.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar marca: " + ex.Message);
                return false;
            }
        }

    }
}
