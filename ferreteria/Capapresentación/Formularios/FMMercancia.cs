using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capapresentación.Formularios
{
    public partial class FMMercancia : Form
    {
        public FMMercancia()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FMMercancia_Load(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form FormularioActivo = null;
        private void abrirFormulariosHijos(Form FormularioHijo)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panel36.Controls.Add(FormularioHijo);
            panel36.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void panel45_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMProducto());
        }

        private void button40_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMMarcas());
        }

        private void button38_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMModelos());
        }

        private void button33_Click(object sender, EventArgs e)
        {
          
        }

        private void button42_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMColores());
        }

        private void button39_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMTipos());
        }

        private void button36_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMPesos());
        }

        private void button35_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMCategoria());
        }

        private void button32_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMAcabados());
        }

        private void button34_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FMDiametros());
        }
    }
}
