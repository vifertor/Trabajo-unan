using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capadato.Metodos;
namespace Capanegocio.Entidad
{
   public class ACABADOS
    {

        public int ID_Acabado { get; set; }
        public string Name_Acabados { get; set; }
        public bool Estado { get; set; }

        CLASEACABADOS claseAcabados = new CLASEACABADOS();

        public DataTable ListarAcabados()
        {
            try
            {
                return claseAcabados.ListarAcabados();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarAcabado(string Name_Acabados)
        {
            try
            {
                return claseAcabados.InsertarAcabado(Name_Acabados);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool ModificarAcabado(int ID_Acabado, string Name_Acabados)
        {
            try
            {
                return claseAcabados.ModificarAcabado(ID_Acabado, Name_Acabados);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool EliminarAcabado(int ID_Acabado)
        {
            try
            {
                return claseAcabados.EliminarAcabado(ID_Acabado);
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
