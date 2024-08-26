using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capanegocio.Entidad;
namespace Capapresentación.Formularios
{
    public partial class FMColores : Form
    {
        int ID_Colores = 0;
        COLORES colores = new COLORES();
        public FMColores()
        {
            InitializeComponent();
        }
        private void MostrarColores()
        {
            DTColores.DataSource = null;
            COLORES obj = new COLORES();
            DTColores.DataSource = obj.ListarColores();
        }
        private void FMColores_Load(object sender, EventArgs e)
        {
            MostrarColores();
            TXTColor.Enabled = false;

            BTNNuevo.Enabled = true;
            BTNCancelar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
        }

        private void DTColores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ID_Colores = Convert.ToInt32(DTColores.CurrentRow.Cells["ID_Colores"].Value);
            TXTColor.Text = DTColores.CurrentRow.Cells["Name_Colores"].Value.ToString();

            TXTColor.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;
        }

        private void TXTColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTColor.Enabled = true;
            TXTColor.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Colores = 0;

        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (ID_Colores > 0)
            {
                if (colores.ModificarColores(ID_Colores, TXTColor.Text))
                {
                    MessageBox.Show("Color modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el color");
                }
            }
            else
            {
                if (colores.InsertarColores(TXTColor.Text))
                {
                    MessageBox.Show("Color guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar el color");
                }
            }
            MostrarColores();
            TXTColor.Enabled = false;
            TXTColor.Text = "";
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Colores > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el color?", "Eliminar Color", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (colores.EliminarColores(ID_Colores))
                    {
                        MessageBox.Show("Color eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el color");
                    }
                    MostrarColores();
                    TXTColor.Enabled = false;
                    TXTColor.Text = "";

                    BTNGuardar.Enabled = false;
                    BTNEliminar.Enabled = false;
                    BTNCancelar.Enabled = false;
                    BTNNuevo.Enabled = true;
                }
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = true;
            TXTColor.Enabled = false;
            TXTColor.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarColores();
        }
    }
}
