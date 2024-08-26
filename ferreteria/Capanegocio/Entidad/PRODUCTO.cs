using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capadato.Metodos;


namespace Capanegocio.Entidad
{
  public  class PRODUCTO
    {
        public int ID_Producto { get; set; }
        public string Name_Producto { get; set; }
       
        public bool Estado { get; set; }

        CLASEPRODUCTO claseProducto = new CLASEPRODUCTO();

        public DataTable ListarProductos()
        {
            try
            {
                return claseProducto.ListarProducto();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarProducto(string Name_producto)
        {
            try
            {
                return claseProducto.InsertarProducto(Name_producto);
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
                return claseProducto.ModificarProducto(ID_Producto, Name_Producto);
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
                return claseProducto.EliminarProducto(ID_Producto);
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
