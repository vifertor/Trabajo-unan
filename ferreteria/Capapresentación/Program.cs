using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capapresentación
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Formularios.FMProducto());
            //Application.Run(new Formularios.FMCategoria());
            //Application.Run(new Formularios.FMColores());
            //Application.Run(new Formularios.FMAcabados());
            //Application.Run(new Formularios.FMDiametros());
            //Application.Run(new Formularios.FMMarcas());
            //Application.Run(new Formularios.FMModelos());
            //Application.Run(new Formularios.FMPesos());
            //Application.Run(new Formularios.FMInventario());
            //Application.Run(new Formularios.FMMercancia());

        }
    }
}
