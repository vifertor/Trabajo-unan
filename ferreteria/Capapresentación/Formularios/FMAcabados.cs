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
    public partial class FMAcabados : Form
    {
        int ID_Acabado = 0;
        ACABADOS acabados = new ACABADOS();
        public FMAcabados()
        {
            InitializeComponent();
        }

        private void MostrarAcabados()
        {
            DTAcabados.DataSource = null;
            ACABADOS obj = new ACABADOS();
            DTAcabados.DataSource = obj.ListarAcabados();
        }

        private void FMAcabados_Load(object sender, EventArgs e)
        {
            MostrarAcabados();
            TXTAcabados.Enabled = false;

            BTNNuevo.Enabled = true;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;

        }

        private void TXTAcabados_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTAcabados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Acabado = Convert.ToInt32(DTAcabados.CurrentRow.Cells["ID_Acabado"].Value);
            TXTAcabados.Text = DTAcabados.CurrentRow.Cells["Name_Acabados"].Value.ToString();

            TXTAcabados.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTAcabados.Enabled = true;
            TXTAcabados.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Acabado = 0;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (ID_Acabado > 0)
            {
                if (acabados.ModificarAcabado(ID_Acabado, TXTAcabados.Text))
                {
                    MessageBox.Show("Acabado modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el acabado");
                }
            }
            else
            {
                if (acabados.InsertarAcabado(TXTAcabados.Text))
                {
                    MessageBox.Show("Acabado guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar el acabado");
                }
            }
            MostrarAcabados();
            TXTAcabados.Enabled = false;
            TXTAcabados.Text = "";
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;

        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Acabado > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el acabado?", "Eliminar Acabado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (acabados.EliminarAcabado(ID_Acabado))
                    {
                        MessageBox.Show("Acabado eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el acabado");
                    }
                    MostrarAcabados();
                    TXTAcabados.Enabled = false;
                    TXTAcabados.Text = "";

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
            TXTAcabados.Enabled = false;
            TXTAcabados.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarAcabados();
        }
    }
}
