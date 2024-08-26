using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capadato.Metodos;
namespace Capanegocio.Entidad
{
   public class CATEGORIA
    {


        public int ID_Categoria { get; set; }
        public string Name_Categoria { get; set; }
        public bool Estado { get; set; }

        CLASECATEGORIA claseCategoria = new CLASECATEGORIA();

        public DataTable ListarCategorias()
        {
            try
            {
                return claseCategoria.ListarCategoria();
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
                return claseCategoria.InsertarCategoria(Name_Categoria);
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
                return claseCategoria.ModificarCategoria(ID_Categoria, Name_Categoria);
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
                return claseCategoria.EliminarCategoria(ID_Categoria);
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
