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
   public class MODELO
    {


        public int ID_Modelos { get; set; }
        public string Name_Modelos { get; set; }
        public bool Estado { get; set; }

        private CLASEMODELOS claseModelo = new CLASEMODELOS();

        public DataTable ListarModelos()
        {
            try
            {
                return claseModelo.ListarModelos();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarModelo(string Name_Modelos)
        {
            try
            {
                return claseModelo.InsertarModelo(Name_Modelos);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool ModificarModelo(int ID_Modelos, string Name_Modelos)
        {
            try
            {
                return claseModelo.ModificarModelo(ID_Modelos, Name_Modelos);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool EliminarModelo(int ID_Modelos)
        {
            try
            {
                return claseModelo.EliminarModelo(ID_Modelos);
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
