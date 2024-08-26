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
    public partial class FMPesos : Form
    {
        public FMPesos()
        {
            InitializeComponent();
        }
        private int ID_Peso = 0;
        private PESOS pesos = new PESOS();

        private void MostrarPesos()
        {
            DTPesos.DataSource = null;
            MODELO obj = new MODELO();
            DTPesos.DataSource = pesos.ListarPesos();
  
        }


        private void FMPesos_Load(object sender, EventArgs e)
        {
            MostrarPesos();
            TXTNamePeso.Enabled = false;
            TXTLibra.Enabled = false;
            TXTDetallesPeso.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;
        }

        private void BTNPesos_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTPesos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Peso = Convert.ToInt32(DTPesos.CurrentRow.Cells["ID_Peso"].Value);
            TXTNamePeso.Text = DTPesos.CurrentRow.Cells["Name_Peso"].Value.ToString();
            TXTLibra.Text = DTPesos.CurrentRow.Cells["Libras"].Value.ToString();
            TXTDetallesPeso.Text = DTPesos.CurrentRow.Cells["Detalles_Peso"].Value.ToString();

            TXTNamePeso.Enabled = true;
            TXTDetallesPeso.Enabled = true;
            TXTLibra.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;

        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Peso > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el peso?", "Eliminar Peso", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (pesos.EliminarPeso(ID_Peso))
                    {
                        MessageBox.Show("Peso eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el peso");
                    }
                    MostrarPesos();
                    TXTNamePeso.Enabled = false;
                    TXTNamePeso.Text = "";
                    TXTDetallesPeso.Text = "";
                    TXTLibra.Text = "";

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
                TXTNamePeso.Enabled = false;
                TXTNamePeso.Text = "";
                TXTDetallesPeso.Text = "";
                TXTLibra.Text = "";
            TXTLibra.Enabled = false;
            TXTDetallesPeso.Enabled = false;
                BTNGuardar.Enabled = false;
                BTNEliminar.Enabled = false;
                BTNCancelar.Enabled = false;
                MostrarPesos();
            }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            float libras;
            if (float.TryParse(TXTLibra.Text, out libras))
            {
                if (ID_Peso > 0)
                {
                    if (pesos.ModificarPeso(ID_Peso, TXTNamePeso.Text, libras, TXTDetallesPeso.Text))
                    {
                        MessageBox.Show("Peso modificado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el peso");
                    }
                }
                else
                {
                    if (pesos.InsertarPeso(TXTNamePeso.Text, libras, TXTDetallesPeso.Text))
                    {
                        MessageBox.Show("Peso guardado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el peso");
                    }
                }
                MostrarPesos();
                TXTNamePeso.Enabled = false;
                TXTNamePeso.Text = "";
                TXTDetallesPeso.Text = "";
                TXTLibra.Text = "";

                BTNGuardar.Enabled = false;
                BTNEliminar.Enabled = false;
                BTNCancelar.Enabled = false;
                BTNNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para Libras");
            }
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTNamePeso.Enabled = true;
            TXTNamePeso.Text = "";
            TXTDetallesPeso.Enabled = true;
            TXTDetallesPeso.Text = "";
            TXTLibra.Text = "";
            TXTLibra.Enabled = true;


            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Peso = 0;
        }

        private void TXTDetallesPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTLibra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
