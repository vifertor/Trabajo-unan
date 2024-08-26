using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capadato.Metodos
{
   public class CLASEINVENTARIO
    {

        SqlCommand Command = new SqlCommand();
        Claseconexion conexion = new Claseconexion();

        public DataTable ListarInventarios()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader;
                DataTable dt = new DataTable();
                command.Connection = conexion.OpenConnection();
                command.CommandText = "sp_mostrarInventarios";
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

        public bool InsertarInventario(int ID_Producto, int ID_Categoria, int ID_Marca, int ID_Modelos, int ID_Tipos, int ID_Colores, int ID_Diametros, int ID_Peso, int ID_Material, int ID_Acabados, int Cantidad_Articulo, decimal Precio_Unidad)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_ingresarInventario";
                command.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                command.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
                command.Parameters.AddWithValue("@ID_Marca", ID_Marca);
                command.Parameters.AddWithValue("@ID_Modelos", ID_Modelos);
                command.Parameters.AddWithValue("@ID_Tipos", ID_Tipos);
                command.Parameters.AddWithValue("@ID_Colores", ID_Colores);
                command.Parameters.AddWithValue("@ID_Diametros", ID_Diametros);
                command.Parameters.AddWithValue("@ID_Peso", ID_Peso);
                command.Parameters.AddWithValue("@ID_Material", ID_Material);
                command.Parameters.AddWithValue("@ID_Acabados", ID_Acabados);
                command.Parameters.AddWithValue("@Cantidad_Articulo", Cantidad_Articulo);
                command.Parameters.AddWithValue("@Precio_Unidad", Precio_Unidad);

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

        public bool ModificarInventario(int ID_Inventario, int ID_Producto, int ID_Categoria, int ID_Marca, int ID_Modelos, int ID_Tipos, int ID_Colores, int ID_Diametros, int ID_Peso, int ID_Material, int ID_Acabados, int Cantidad_Articulo, decimal Precio_Unidad)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conexion.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_actualizarInventario";
                command.Parameters.AddWithValue("@ID_Inventario", ID_Inventario);
                command.Parameters.AddWithValue("@ID_Producto", ID_Producto);
                command.Parameters.AddWithValue("@ID_Categoria", ID_Categoria);
                command.Parameters.AddWithValue("@ID_Marca", ID_Marca);
                command.Parameters.AddWithValue("@ID_Modelos", ID_Modelos);
                command.Parameters.AddWithValue("@ID_Tipos", ID_Tipos);
                command.Parameters.AddWithValue("@ID_Colores", ID_Colores);
                command.Parameters.AddWithValue("@ID_Diametros", ID_Diametros);
                command.Parameters.AddWithValue("@ID_Peso", ID_Peso);
                command.Parameters.AddWithValue("@ID_Material", ID_Material);
                command.Parameters.AddWithValue("@ID_Acabados", ID_Acabados);
                command.Parameters.AddWithValue("@Cantidad_Articulo", Cantidad_Articulo);
                command.Parameters.AddWithValue("@Precio_Unidad", Precio_Unidad);

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



        public DataTable ListarIDsProductos()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listarproductos";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsColores()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listarcolores";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsTipos()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listartipos";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsDiametros()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listardiametros";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsMateriales()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listarmateriales";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsModelos()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listarmodelos";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsMarcas()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listarmarcas";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsCategorias()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listarcategorias";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsAcabados()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listaracabados";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }

        public DataTable ListarIDsPesos()
        {
            DataTable Tabla = new DataTable();
            Command.Connection = conexion.OpenConnection();
            Command.CommandText = "listarpesos";
            Command.CommandType = CommandType.StoredProcedure;
            SqlDataReader LeerFilas = Command.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion.CloseConnection();
            return Tabla;
        }
    }
}
