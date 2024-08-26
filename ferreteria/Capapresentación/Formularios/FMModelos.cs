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
    public partial class FMModelos : Form
    {
        public FMModelos()
        {
            InitializeComponent();
        }
        int ID_Modelos = 0;
        MODELO modelos = new MODELO();

        private void FMModelos_Load(object sender, EventArgs e)
        {
            MostrarModelos();
            TXTModelo.Enabled = false;

            BTNNuevo.Enabled = true;
            BTNCancelar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;

        }
        private void MostrarModelos()
        {
            DTModelo.DataSource = null;
            MODELO obj = new MODELO();
            DTModelo.DataSource = obj.ListarModelos();
        }


        private void TXTModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTModelo.Enabled = true;
            TXTModelo.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Modelos = 0;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (ID_Modelos > 0)
            {
                if (modelos.ModificarModelo(ID_Modelos, TXTModelo.Text))
                {
                    MessageBox.Show("Modelo modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el modelo");
                }
            }
            else
            {
                if (modelos.InsertarModelo(TXTModelo.Text))
                {
                    MessageBox.Show("Modelo guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar el modelo");
                }
            }
            MostrarModelos();
            TXTModelo.Enabled = false;
            TXTModelo.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;

        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Modelos > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el modelo?", "Eliminar Modelo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (modelos.EliminarModelo(ID_Modelos))
                    {
                        MessageBox.Show("Modelo eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el modelo");
                    }
                    MostrarModelos();
                    TXTModelo.Enabled = false;
                    TXTModelo.Text = "";

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
            TXTModelo.Enabled = false;
            TXTModelo.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarModelos();
        }

        private void DTModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Modelos = Convert.ToInt32(DTModelo.CurrentRow.Cells["ID_Modelos"].Value);
            TXTModelo.Text = DTModelo.CurrentRow.Cells["Name_Modelos"].Value.ToString();

            TXTModelo.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;

        }
    }
}
