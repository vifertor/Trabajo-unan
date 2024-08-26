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
    public partial class FMCategoria : Form
    {
        int ID_Categoria = 0;
        CATEGORIA categoria = new CATEGORIA();
        public FMCategoria()
        {
            InitializeComponent();
        }
        private void MostrarCategoria()
        {
            DTCategoria.DataSource = null;
            CATEGORIA obj = new CATEGORIA();
            DTCategoria.DataSource = obj.ListarCategorias();
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTCategoria.Enabled = true;
            TXTCategoria.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Categoria = 0;
        }

        private void DTCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Categoria = Convert.ToInt32(DTCategoria.CurrentRow.Cells["ID_Categoria"].Value);
            TXTCategoria.Text = DTCategoria.CurrentRow.Cells["Name_Categoria"].Value.ToString();

            TXTCategoria.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;

        }

        private void FMCategoria_Load(object sender, EventArgs e)
        {
            MostrarCategoria();
            TXTCategoria.Enabled = false;

            BTNNuevo.Enabled = true;
            BTNCancelar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {

            if (ID_Categoria > 0)
            {
                if (categoria.ModificarCategoria(ID_Categoria, TXTCategoria.Text))
                {
                    MessageBox.Show("Categoría modificada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar la categoría");
                }
            }
            else
            {
                if (categoria.InsertarCategoria(TXTCategoria.Text))
                {
                    MessageBox.Show("Categoría guardada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar la categoría");
                }
            }
            MostrarCategoria();
            TXTCategoria.Enabled = false;
            TXTCategoria.Text = "";
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;

        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Categoria > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la categoría?", "Eliminar Categoría", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (categoria.EliminarCategoria(ID_Categoria))
                    {
                        MessageBox.Show("Categoría eliminada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la categoría");
                    }
                    MostrarCategoria();
                    TXTCategoria.Enabled = false;
                    TXTCategoria.Text = "";

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
            TXTCategoria.Enabled = false;
            TXTCategoria.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarCategoria();
        }

        private void TXTCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
