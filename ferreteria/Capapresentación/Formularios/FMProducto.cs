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
    public partial class FMProducto : Form
    {

        int ID_Producto = 0;
        PRODUCTO producto = new PRODUCTO();

        public FMProducto()
        {
            InitializeComponent();
        }

        private void MostrarProducto()
        {

            DTPRODUCTO.DataSource = null;
            PRODUCTO obj = new PRODUCTO();
            DTPRODUCTO.DataSource = obj.ListarProductos();
          

        }


        private void DTPRODUCTO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Producto = Convert.ToInt32(DTPRODUCTO.CurrentRow.Cells["ID_Producto"].Value);
            TXTProducto.Text = DTPRODUCTO.CurrentRow.Cells["Name_Producto"].Value.ToString();


            TXTProducto.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;
        }

        private void FMProducto_Load(object sender, EventArgs e)
        {
            MostrarProducto();
            TXTProducto.Enabled = false;
           
            BTNNuevo.Enabled = true;
            BTNCancelar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            if (ID_Producto > 0)
            {
                if (producto.ModificarProducto(ID_Producto, TXTProducto.Text))
                {
                    MessageBox.Show("Ciclo modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el ciclo");
                }
            }
            else
            {
                if (producto.InsertarProducto(TXTProducto.Text))
                {
                    MessageBox.Show("Ciclo guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar el ciclo");
                }
                MostrarProducto();
                TXTProducto.Enabled = false;
                TXTProducto.Text = "";
                BTNGuardar.Enabled = false;
                BTNEliminar.Enabled = false;
                BTNCancelar.Enabled = false;
                BTNGuardar.Enabled = true;
                BTNNuevo.Enabled = true;

            }


        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            TXTProducto.Enabled = true;
            TXTProducto.Text = "";

            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            ID_Producto = 0;
        }

        private void TXTProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {

            BTNNuevo.Enabled = true;
            TXTProducto.Enabled = false;
            TXTProducto.Text = "";
       
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            MostrarProducto();


        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (ID_Producto > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el ciclo?", "Eliminar Ciclo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (producto.EliminarProducto(ID_Producto))
                    {
                        MessageBox.Show("Ciclo eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el ciclo");
                    }
                    MostrarProducto();
                    TXTProducto.Enabled = false;
                    TXTProducto.Text = "";

                    BTNGuardar.Enabled = false;
                    BTNEliminar.Enabled = false;
                    BTNCancelar.Enabled = false;
                    BTNGuardar.Enabled = false;
                    BTNNuevo.Enabled = true;




                }
            }
        }
    }
}
