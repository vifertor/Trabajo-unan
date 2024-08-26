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
    public partial class FMInventario : Form
    {
        public FMInventario()
        {
            InitializeComponent();
        }
        INVENTARIO inventario = new INVENTARIO();
        int ID_Inventario = 0;
        private void FMInventario_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarMarcas();
            ListarModelos();
            ListarTipos();
            ListarColores();
            ListarDiametros();
            ListarPesos();
            ListarMateriales();
            ListarAcabados();
            MostrarInventarios();
            ResetForm();
        }

        private void ListarCategorias()
        {
            CBICategoria.DataSource = inventario.ListarIDsCategorias();
            CBICategoria.DisplayMember = "Name_Categoria";
            CBICategoria.ValueMember = "ID_Categoria";
        }

        private void ListarMarcas()
        {
            CBIMarca.DataSource = inventario.ListarIDsMarcas();
            CBIMarca.DisplayMember = "Name_Marca";
            CBIMarca.ValueMember = "ID_Marca";
        }

        private void ListarModelos()
        {
            CBIModelo.DataSource = inventario.ListarIDsModelos();
            CBIModelo.DisplayMember = "Name_Modelos";
            CBIModelo.ValueMember = "ID_Modelos";
        }

        private void ListarTipos()
        {
            CBITipos.DataSource = inventario.ListarIDsTipos();
            CBITipos.DisplayMember = "Name_Tipo";
            CBITipos.ValueMember = "ID_Tipos";
        }

        private void ListarColores()
        {
            CBIColores.DataSource = inventario.ListarIDsColores();
            CBIColores.DisplayMember = "Name_Colores";
            CBIColores.ValueMember = "ID_Colores";
        }

        private void ListarDiametros()
        {
            CBIDiametros.DataSource = inventario.ListarIDsDiametros();
            CBIDiametros.DisplayMember = "Name_Diametro";
            CBIDiametros.ValueMember = "ID_Diametros";
        }

        private void ListarPesos()
        {
            CBIPeso.DataSource = inventario.ListarIDsPesos();
            CBIPeso.DisplayMember = "Name_Peso";
            CBIPeso.ValueMember = "ID_Peso";
        }

        private void ListarMateriales()
        {
            CBIMateriales.DataSource = inventario.ListarIDsMateriales();
            CBIMateriales.DisplayMember = "Name_Material";
            CBIMateriales.ValueMember = "ID_Material";
        }

        private void ListarAcabados()
        {
            CBIAcabados.DataSource = inventario.ListarIDsAcabados();
            CBIAcabados.DisplayMember = "Name_Acabados";
            CBIAcabados.ValueMember = "ID_Acabado";
        }

        private void MostrarInventarios()
        {
            DTInventario.DataSource = inventario.ListarInventarios();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            ResetForm();
            TXTCantidadArticulo.Enabled = true;
            TXTPrecio_Unidad.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNEliminar.Enabled = false;
        }

     
        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(CBIProducto.SelectedValue);
            int idCategoria = Convert.ToInt32(CBICategoria.SelectedValue);
            int idMarca = Convert.ToInt32(CBIMarca.SelectedValue);
            int idModelos = Convert.ToInt32(CBIModelo.SelectedValue);
            int idTipos = Convert.ToInt32(CBITipos.SelectedValue);
            int idColores = Convert.ToInt32(CBIColores.SelectedValue);
            int idDiametros = Convert.ToInt32(CBIDiametros.SelectedValue);
            int idPeso = Convert.ToInt32(CBIPeso.SelectedValue);
            int idMaterial = Convert.ToInt32(CBIMateriales.SelectedValue);
            int idAcabados = Convert.ToInt32(CBIAcabados.SelectedValue);
            int cantidadArticulo = Convert.ToInt32(TXTCantidadArticulo.Text);
            decimal precioUnidad = Convert.ToDecimal(TXTPrecio_Unidad.Text);

            if (ID_Inventario > 0)
            {
                // Modificar
                if (inventario.ModificarInventario(ID_Inventario, idProducto, idCategoria, idMarca, idModelos, idTipos, idColores, idDiametros, idPeso, idMaterial, idAcabados, cantidadArticulo, precioUnidad))
                {
                    MessageBox.Show("Inventario modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar el inventario");
                }
            }
            else
            {
                // Insertar
                if (inventario.InsertarInventario(idProducto, idCategoria, idMarca, idModelos, idTipos, idColores, idDiametros, idPeso, idMaterial, idAcabados, cantidadArticulo, precioUnidad))
                {
                    MessageBox.Show("Inventario guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar el inventario");
                }
            }


            MostrarInventarios();
            ResetForm();
        }

        private void CBITipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIDiametros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIPeso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CBICategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBIAcabados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTCantidadArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPrecio_Unidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DTInventario.Rows[e.RowIndex];
            ID_Inventario = Convert.ToInt32(row.Cells["ID_Inventario"].Value);
            CBIProducto.SelectedValue = row.Cells["ID_Producto"].Value;
            CBICategoria.SelectedValue = row.Cells["ID_Categoria"].Value;
            CBIMarca.SelectedValue = row.Cells["ID_Marca"].Value;
            CBIModelo.SelectedValue = row.Cells["ID_Modelos"].Value;
            CBIPeso.SelectedValue = row.Cells["ID_Peso"].Value;
            CBIDiametros.SelectedValue = row.Cells["ID_Diametros"].Value;
            TXTCantidadArticulo.Text = row.Cells["Cantidad_Articulo"].Value.ToString();
            TXTPrecio_Unidad.Text = row.Cells["Precio_Unidad"].Value.ToString();

            TXTCantidadArticulo.Enabled = true;
            TXTPrecio_Unidad.Enabled = true;
            BTNGuardar.Enabled = true;
            BTNEliminar.Enabled = true;
            BTNCancelar.Enabled = true;
            BTNNuevo.Enabled = false;
            CBIProducto.Enabled = false;
            CBICategoria.Enabled = false;
            CBIMarca.Enabled = false;
            CBIModelo.Enabled = false;
            CBIPeso.Enabled = false;
            CBIDiametros.Enabled = false;
        }


        private void ResetForm()
        {
            ID_Inventario = 0;
            TXTCantidadArticulo.Text = "";
            TXTPrecio_Unidad.Text = "";
            TXTCantidadArticulo.Enabled = false;
            TXTPrecio_Unidad.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCancelar.Enabled = false;
            BTNNuevo.Enabled = true;
            CBIProducto.Enabled = true;
            CBICategoria.Enabled = true;
            CBIMarca.Enabled = true;
            CBIModelo.Enabled = true;
            CBIPeso.Enabled = true;
            CBIDiametros.Enabled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
