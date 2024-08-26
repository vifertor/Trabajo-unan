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
    public partial class FMTipos : Form
    {

        int ID_Tipos = 0;
        TIPOS tipos = new TIPOS();
        public FMTipos()
        {
            InitializeComponent();
        }

        private void MostrarTipos()
        {
            DTTipos.DataSource = null;
            TIPOS obj = new TIPOS();
            DTTipos.DataSource = obj.ListarTipos();
        }


        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Tipos > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el tipo?", "Eliminar Tipo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (tipos.EliminarTipo(ID_Tipos))
                    {
                        MessageBox.Show("Tipo eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el tipo");
                    }
                    MostrarTipos();
                    TXTTipos.Enabled = false;
                    TXTTipos.Text = "";

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
            TXTTipos.Enabled = false;
            TXTTipos.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarTipos();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (ID_Tipos > 0)
            {
                if (tipos.ModificarTipo(ID_Tipos, TXTTipos.Text))
                {
                    MessageBox.Show("Tipo modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el tipo");
                }
            }
            else
            {
                if (tipos.InsertarTipo(TXTTipos.Text))
                {
                    MessageBox.Show("Tipo guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar el tipo");
                }
            }
            MostrarTipos();
            TXTTipos.Enabled = false;
            TXTTipos.Text = "";
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;
        }

        private void DTTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Tipos = Convert.ToInt32(DTTipos.CurrentRow.Cells["ID_Tipos"].Value);
            TXTTipos.Text = DTTipos.CurrentRow.Cells["Name_Tipo"].Value.ToString();

            TXTTipos.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;
        }

        private void TXTTipos_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTTipos.Enabled = true;
            TXTTipos.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Tipos = 0;
        }

        private void FMTipos_Load(object sender, EventArgs e)
        {
            MostrarTipos();
            TXTTipos.Enabled = false;

            BTNNuevo.Enabled = true;
            BTNCancelar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
        }
    }
}
