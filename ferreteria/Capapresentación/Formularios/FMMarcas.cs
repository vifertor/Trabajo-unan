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
    public partial class FMMarcas : Form
    {
        public FMMarcas()
        {
            InitializeComponent();
        }


        int ID_Marca = 0;
        MARCA marca = new MARCA();

        private void TXTMarca_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarMarcas()
        {
            DTMarca.DataSource = null;
            MARCA obj = new MARCA();
            DTMarca.DataSource = obj.ListarMarcas();
        }

        private void DTMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Marca = Convert.ToInt32(DTMarca.CurrentRow.Cells["ID_Marca"].Value);
            TXTMarca.Text = DTMarca.CurrentRow.Cells["Name_Marca"].Value.ToString();

            TXTMarca.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;
        }

        private void FMMarcas_Load(object sender, EventArgs e)
        {
            MostrarMarcas();
            TXTMarca.Enabled = false;

            BTNNuevo.Enabled = true;
            BTNCancelar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;

        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTMarca.Enabled = true;
            TXTMarca.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Marca = 0;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (ID_Marca > 0)
            {
                if (marca.ModificarMarca(ID_Marca, TXTMarca.Text))
                {
                    MessageBox.Show("Marca modificada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar la marca");
                }
            }
            else
            {
                if (marca.InsertarMarca(TXTMarca.Text))
                {
                    MessageBox.Show("Marca guardada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar la marca");
                }
            }

            MostrarMarcas();
            TXTMarca.Enabled = false;
            TXTMarca.Text = "";
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Marca > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Eliminar Marca", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (marca.EliminarMarca(ID_Marca))
                    {
                        MessageBox.Show("Marca eliminada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la marca");
                    }
                    MostrarMarcas();
                    TXTMarca.Enabled = false;
                    TXTMarca.Text = "";

                    BTNGuardar.Enabled = false;
                    BTNEliminar.Enabled = false;
                    BTNCancelar.Enabled = false;
                    BTNNuevo.Enabled = true;
                //}
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = true;
            TXTMarca.Enabled = false;
            TXTMarca.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarMarcas();
        }
    }
}
