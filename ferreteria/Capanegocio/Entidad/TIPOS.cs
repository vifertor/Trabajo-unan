using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capadato.Metodos;
namespace Capanegocio.Entidad
{
   public class TIPOS
    {
        public int ID_Tipos { get; set; }
        public string Name_Tipo { get; set; }
        public bool Estado { get; set; }

        CLASETIPOS claseTipo = new CLASETIPOS();

        public DataTable ListarTipos()
        {
            try
            {
                return claseTipo.ListarTipos();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarTipo(string Name_Tipo)
        {
            try
            {
                return claseTipo.InsertarTipo(Name_Tipo);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool ModificarTipo(int ID_Tipos, string Name_Tipo)
        {
            try
            {
                return claseTipo.ModificarTipo(ID_Tipos, Name_Tipo);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool EliminarTipo(int ID_Tipos)
        {
            try
            {
                return claseTipo.EliminarTipo(ID_Tipos);
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
