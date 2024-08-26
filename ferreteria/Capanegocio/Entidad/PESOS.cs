using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capadato.Metodos;

namespace Capanegocio.Entidad
{
  public  class PESOS
    {

        public int ID_Peso { get; set; }
        public string Name_Peso { get; set; }
        public float Libras { get; set; }
        public string Detalles_Peso { get; set; }
        public bool Estado { get; set; }

        private CLASEPESOS clasePesos = new CLASEPESOS();

        public DataTable ListarPesos()
        {
            try
            {
                return clasePesos.ListarPesos();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return null;
            }
        }

        public bool InsertarPeso(string Name_Peso, float Libras, string Detalles_Peso)
        {
            try
            {
                return clasePesos.InsertarPeso(Name_Peso, Libras, Detalles_Peso);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool ModificarPeso(int ID_Peso, string Name_Peso, float Libras, string Detalles_Peso)
        {
            try
            {
                return clasePesos.ModificarPeso(ID_Peso, Name_Peso, Libras, Detalles_Peso);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

        public bool EliminarPeso(int ID_Peso)
        {
            try
            {
                return clasePesos.EliminarPeso(ID_Peso);
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
