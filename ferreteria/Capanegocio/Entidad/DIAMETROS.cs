using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capadato.Metodos;
namespace Capanegocio.Entidad
{
   public class DIAMETROS
    {

        public int ID_Diametros { get; set; }
        public string Name_Diametro { get; set; }
        public bool Estado { get; set; }

        CLASEDIAMETROS claseDiametro = new CLASEDIAMETROS();

        public DataTable ListarDiametros()
        {
            try
            {
                return claseDiametro.ListarDiametros();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarDiametro(string Name_Diametro)
        {
            try
            {
                return claseDiametro.InsertarDiametro(Name_Diametro);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool ModificarDiametro(int ID_Diametros, string Name_Diametro)
        {
            try
            {
                return claseDiametro.ModificarDiametro(ID_Diametros, Name_Diametro);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool EliminarDiametro(int ID_Diametros)
        {
            try
            {
                return claseDiametro.EliminarDiametro(ID_Diametros);
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
