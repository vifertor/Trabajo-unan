
namespace Capapresentación.Formularios
{
    partial class FMInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.CBIMarca = new System.Windows.Forms.ComboBox();
            this.CBIProducto = new System.Windows.Forms.ComboBox();
            this.CBICategoria = new System.Windows.Forms.ComboBox();
            this.CBIModelo = new System.Windows.Forms.ComboBox();
            this.CBITipos = new System.Windows.Forms.ComboBox();
            this.CBIColores = new System.Windows.Forms.ComboBox();
            this.CBIDiametros = new System.Windows.Forms.ComboBox();
            this.CBIPeso = new System.Windows.Forms.ComboBox();
            this.CBIMateriales = new System.Windows.Forms.ComboBox();
            this.CBIAcabados = new System.Windows.Forms.ComboBox();
            this.TXTCantidadArticulo = new System.Windows.Forms.TextBox();
            this.TXTPrecio_Unidad = new System.Windows.Forms.TextBox();
            this.lsd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DTInventario = new System.Windows.Forms.DataGridView();
            this.BTNEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(218, 260);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTNGuardar.TabIndex = 1;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(390, 260);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 3;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(57, 260);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(75, 23);
            this.BTNNuevo.TabIndex = 4;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // CBIMarca
            // 
            this.CBIMarca.FormattingEnabled = true;
            this.CBIMarca.Location = new System.Drawing.Point(126, 43);
            this.CBIMarca.Name = "CBIMarca";
            this.CBIMarca.Size = new System.Drawing.Size(63, 21);
            this.CBIMarca.TabIndex = 7;
            this.CBIMarca.SelectedIndexChanged += new System.EventHandler(this.CBIMarca_SelectedIndexChanged);
            // 
            // CBIProducto
            // 
            this.CBIProducto.FormattingEnabled = true;
            this.CBIProducto.Location = new System.Drawing.Point(32, 44);
            this.CBIProducto.Name = "CBIProducto";
            this.CBIProducto.Size = new System.Drawing.Size(72, 21);
            this.CBIProducto.TabIndex = 8;
            this.CBIProducto.SelectedIndexChanged += new System.EventHandler(this.CBIProducto_SelectedIndexChanged);
            // 
            // CBICategoria
            // 
            this.CBICategoria.FormattingEnabled = true;
            this.CBICategoria.Location = new System.Drawing.Point(32, 97);
            this.CBICategoria.Name = "CBICategoria";
            this.CBICategoria.Size = new System.Drawing.Size(72, 21);
            this.CBICategoria.TabIndex = 9;
            this.CBICategoria.SelectedIndexChanged += new System.EventHandler(this.CBICategoria_SelectedIndexChanged);
            // 
            // CBIModelo
            // 
            this.CBIModelo.FormattingEnabled = true;
            this.CBIModelo.Location = new System.Drawing.Point(126, 96);
            this.CBIModelo.Name = "CBIModelo";
            this.CBIModelo.Size = new System.Drawing.Size(63, 21);
            this.CBIModelo.TabIndex = 10;
            this.CBIModelo.SelectedIndexChanged += new System.EventHandler(this.CBIModelo_SelectedIndexChanged);
            // 
            // CBITipos
            // 
            this.CBITipos.FormattingEnabled = true;
            this.CBITipos.Location = new System.Drawing.Point(211, 44);
            this.CBITipos.Name = "CBITipos";
            this.CBITipos.Size = new System.Drawing.Size(81, 21);
            this.CBITipos.TabIndex = 11;
            this.CBITipos.SelectedIndexChanged += new System.EventHandler(this.CBITipos_SelectedIndexChanged);
            // 
            // CBIColores
            // 
            this.CBIColores.FormattingEnabled = true;
            this.CBIColores.Location = new System.Drawing.Point(211, 97);
            this.CBIColores.Name = "CBIColores";
            this.CBIColores.Size = new System.Drawing.Size(81, 21);
            this.CBIColores.TabIndex = 12;
            this.CBIColores.SelectedIndexChanged += new System.EventHandler(this.CBIColores_SelectedIndexChanged);
            // 
            // CBIDiametros
            // 
            this.CBIDiametros.FormattingEnabled = true;
            this.CBIDiametros.Location = new System.Drawing.Point(329, 44);
            this.CBIDiametros.Name = "CBIDiametros";
            this.CBIDiametros.Size = new System.Drawing.Size(81, 21);
            this.CBIDiametros.TabIndex = 13;
            this.CBIDiametros.SelectedIndexChanged += new System.EventHandler(this.CBIDiametros_SelectedIndexChanged);
            // 
            // CBIPeso
            // 
            this.CBIPeso.FormattingEnabled = true;
            this.CBIPeso.Location = new System.Drawing.Point(329, 97);
            this.CBIPeso.Name = "CBIPeso";
            this.CBIPeso.Size = new System.Drawing.Size(81, 21);
            this.CBIPeso.TabIndex = 14;
            this.CBIPeso.SelectedIndexChanged += new System.EventHandler(this.CBIPeso_SelectedIndexChanged);
            // 
            // CBIMateriales
            // 
            this.CBIMateriales.FormattingEnabled = true;
            this.CBIMateriales.Location = new System.Drawing.Point(437, 44);
            this.CBIMateriales.Name = "CBIMateriales";
            this.CBIMateriales.Size = new System.Drawing.Size(81, 21);
            this.CBIMateriales.TabIndex = 15;
            this.CBIMateriales.SelectedIndexChanged += new System.EventHandler(this.CBIMateriales_SelectedIndexChanged);
            // 
            // CBIAcabados
            // 
            this.CBIAcabados.FormattingEnabled = true;
            this.CBIAcabados.Location = new System.Drawing.Point(437, 97);
            this.CBIAcabados.Name = "CBIAcabados";
            this.CBIAcabados.Size = new System.Drawing.Size(81, 21);
            this.CBIAcabados.TabIndex = 16;
            this.CBIAcabados.SelectedIndexChanged += new System.EventHandler(this.CBIAcabados_SelectedIndexChanged);
            // 
            // TXTCantidadArticulo
            // 
            this.TXTCantidadArticulo.Location = new System.Drawing.Point(548, 46);
            this.TXTCantidadArticulo.Name = "TXTCantidadArticulo";
            this.TXTCantidadArticulo.Size = new System.Drawing.Size(94, 20);
            this.TXTCantidadArticulo.TabIndex = 18;
            this.TXTCantidadArticulo.TextChanged += new System.EventHandler(this.TXTCantidadArticulo_TextChanged);
            // 
            // TXTPrecio_Unidad
            // 
            this.TXTPrecio_Unidad.Location = new System.Drawing.Point(548, 96);
            this.TXTPrecio_Unidad.Name = "TXTPrecio_Unidad";
            this.TXTPrecio_Unidad.Size = new System.Drawing.Size(93, 20);
            this.TXTPrecio_Unidad.TabIndex = 19;
            this.TXTPrecio_Unidad.TextChanged += new System.EventHandler(this.TXTPrecio_Unidad_TextChanged);
            // 
            // lsd
            // 
            this.lsd.AutoSize = true;
            this.lsd.Location = new System.Drawing.Point(54, 28);
            this.lsd.Name = "lsd";
            this.lsd.Size = new System.Drawing.Size(50, 13);
            this.lsd.TabIndex = 20;
            this.lsd.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tipos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Diametros";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Materiales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cantidad art";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Peso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Acabados";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Precio unidad";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Modelo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(237, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Colores";
            // 
            // DTInventario
            // 
            this.DTInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTInventario.Location = new System.Drawing.Point(12, 145);
            this.DTInventario.Name = "DTInventario";
            this.DTInventario.Size = new System.Drawing.Size(611, 88);
            this.DTInventario.TabIndex = 33;
            this.DTInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTInventario_CellContentClick);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(525, 260);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 34;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            // 
            // FMInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 369);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.DTInventario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsd);
            this.Controls.Add(this.TXTPrecio_Unidad);
            this.Controls.Add(this.TXTCantidadArticulo);
            this.Controls.Add(this.CBIAcabados);
            this.Controls.Add(this.CBIMateriales);
            this.Controls.Add(this.CBIPeso);
            this.Controls.Add(this.CBIDiametros);
            this.Controls.Add(this.CBIColores);
            this.Controls.Add(this.CBITipos);
            this.Controls.Add(this.CBIModelo);
            this.Controls.Add(this.CBICategoria);
            this.Controls.Add(this.CBIProducto);
            this.Controls.Add(this.CBIMarca);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNGuardar);
            this.Name = "FMInventario";
            this.Text = "FMInventario";
            this.Load += new System.EventHandler(this.FMInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.ComboBox CBIMarca;
        private System.Windows.Forms.ComboBox CBIProducto;
        private System.Windows.Forms.ComboBox CBICategoria;
        private System.Windows.Forms.ComboBox CBIModelo;
        private System.Windows.Forms.ComboBox CBITipos;
        private System.Windows.Forms.ComboBox CBIColores;
        private System.Windows.Forms.ComboBox CBIDiametros;
        private System.Windows.Forms.ComboBox CBIPeso;
        private System.Windows.Forms.ComboBox CBIMateriales;
        private System.Windows.Forms.ComboBox CBIAcabados;
        private System.Windows.Forms.TextBox TXTCantidadArticulo;
        private System.Windows.Forms.TextBox TXTPrecio_Unidad;
        private System.Windows.Forms.Label lsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DTInventario;
        private System.Windows.Forms.Button BTNEliminar;
    }
}