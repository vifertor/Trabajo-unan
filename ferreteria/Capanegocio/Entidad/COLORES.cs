using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capadato.Metodos;
namespace Capanegocio.Entidad
{
    public class COLORES
    {
        public int ID_Colores { get; set; }
        public string Name_Colores { get; set; }
        public bool Estado { get; set; }

        CLASECOLORES claseColores = new CLASECOLORES();

        public DataTable ListarColores()
        {
            try
            {
                return claseColores.ListarColores();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarColores(string Name_Colores)
        {
            try
            {
                return claseColores.InsertarColores(Name_Colores);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool ModificarColores(int ID_Colores, string Name_Colores)
        {
            try
            {
                return claseColores.ModificarColores(ID_Colores, Name_Colores);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool EliminarColores(int ID_Colores)
        {
            try
            {
                return claseColores.EliminarColores(ID_Colores);
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
