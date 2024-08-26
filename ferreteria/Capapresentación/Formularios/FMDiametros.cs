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
    public partial class FMDiametros : Form
    {
        int ID_Diametros = 0;
        DIAMETROS diametro = new DIAMETROS();
        public FMDiametros()
        {
            InitializeComponent();
        }

        private void TXTDiametros_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarDiametros()
        {
            DTDiametro.DataSource = null;
            DIAMETROS obj = new DIAMETROS();
            DTDiametro.DataSource = obj.ListarDiametros();
        }
        private void DTDiametro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Diametros = Convert.ToInt32(DTDiametro.CurrentRow.Cells["ID_Diametros"].Value);
            TXTDiametros.Text = DTDiametro.CurrentRow.Cells["Name_Diametro"].Value.ToString();

            TXTDiametros.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {

            BTNNuevo.Enabled = false;
            TXTDiametros.Enabled = true;
            TXTDiametros.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Diametros = 0;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (ID_Diametros > 0)
            {
                if (diametro.ModificarDiametro(ID_Diametros, TXTDiametros.Text))
                {
                    MessageBox.Show("Diámetro modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el diámetro");
                }
            }
            else
            {
                if (diametro.InsertarDiametro(TXTDiametros.Text))
                {
                    MessageBox.Show("Diámetro guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar el diámetro");
                }
            }
            MostrarDiametros();
            TXTDiametros.Enabled = false;
            TXTDiametros.Text = "";
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {

            if (ID_Diametros > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el diámetro?", "Eliminar Diámetro", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (diametro.EliminarDiametro(ID_Diametros))
                    {
                        MessageBox.Show("Diámetro eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el diámetro");
                    }
                    MostrarDiametros();
                    TXTDiametros.Enabled = false;
                    TXTDiametros.Text = "";

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
            TXTDiametros.Enabled = false;
            TXTDiametros.Text = "";

            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarDiametros();
        }

        private void FMDiametros_Load(object sender, EventArgs e)
        {
            MostrarDiametros();
            TXTDiametros.Enabled = false;

            BTNNuevo.Enabled = true;
            BTNCancelar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
        }
    }
}
