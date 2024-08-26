using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capadato.Metodos;
namespace Capanegocio.Entidad
{
  public  class INVENTARIO
    {


        public int ID_Inventario { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Marca { get; set; }
        public int ID_Modelos { get; set; }
        public int ID_Tipos { get; set; }
        public int ID_Colores { get; set; }
        public int ID_Diametros { get; set; }
        public int ID_Peso { get; set; }
        public int ID_Material { get; set; }
        public int ID_Acabados { get; set; }
        public int Cantidad_Articulo { get; set; }
        public decimal Precio_Unidad { get; set; }

        private CLASEINVENTARIO claseInventario = new CLASEINVENTARIO();

        public DataTable ListarInventarios()
        {
            try
            {
                return claseInventario.ListarInventarios();
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
                return claseInventario.InsertarInventario(ID_Producto, ID_Categoria, ID_Marca, ID_Modelos, ID_Tipos, ID_Colores, ID_Diametros, ID_Peso, ID_Material, ID_Acabados, Cantidad_Articulo, Precio_Unidad);
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
                return claseInventario.ModificarInventario(ID_Inventario, ID_Producto, ID_Categoria, ID_Marca, ID_Modelos, ID_Tipos, ID_Colores, ID_Diametros, ID_Peso, ID_Material, ID_Acabados, Cantidad_Articulo, Precio_Unidad);
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
            try
            {
                return claseInventario.ListarIDsProductos();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsColores()
        {
            try
            {
                return claseInventario.ListarIDsColores();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsTipos()
        {
            try
            {
                return claseInventario.ListarIDsTipos();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsDiametros()
        {
            try
            {
                return claseInventario.ListarIDsDiametros();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsMateriales()
        {
            try
            {
                return claseInventario.ListarIDsMateriales();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsModelos()
        {
            try
            {
                return claseInventario.ListarIDsModelos();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsMarcas()
        {
            try
            {
                return claseInventario.ListarIDsMarcas();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsCategorias()
        {
            try
            {
                return claseInventario.ListarIDsCategorias();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsAcabados()
        {
            try
            {
                return claseInventario.ListarIDsAcabados();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public DataTable ListarIDsPesos()
        {
            try
            {
                return claseInventario.ListarIDsPesos();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }
    }
}
