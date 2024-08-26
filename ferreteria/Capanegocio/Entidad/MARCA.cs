using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capadato.Metodos;
using System.Data;
namespace Capanegocio.Entidad
{
   public class MARCA
    {

        public int ID_Marca { get; set; }
        public string Name_Marca { get; set; }
        public bool Estado { get; set; }

        CLASEMARCAS claseMarca = new CLASEMARCAS();

        public DataTable ListarMarcas()
        {
            try
            {
                return claseMarca.ListarMarcas();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

     
        public bool InsertarMarca(string Name_Marca)
        {
            try
            {
                return claseMarca.InsertarMarca(Name_Marca);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

       
        public bool ModificarMarca(int ID_Marca, string Name_Marca)
        {
            try
            {
                return claseMarca.ModificarMarca(ID_Marca, Name_Marca);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

       
        public bool EliminarMarca(int ID_Marca)
        {
            try
            {
                return claseMarca.EliminarMarca(ID_Marca);
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
