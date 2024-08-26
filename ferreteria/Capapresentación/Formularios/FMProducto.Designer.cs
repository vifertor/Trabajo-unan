
namespace Capapresentación.Formularios
{
    partial class FMProducto
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
            this.DTPRODUCTO = new System.Windows.Forms.DataGridView();
            this.TXTProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTPRODUCTO)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPRODUCTO
            // 
            this.DTPRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTPRODUCTO.Location = new System.Drawing.Point(138, 100);
            this.DTPRODUCTO.Name = "DTPRODUCTO";
            this.DTPRODUCTO.ShowCellToolTips = false;
            this.DTPRODUCTO.Size = new System.Drawing.Size(479, 201);
            this.DTPRODUCTO.TabIndex = 0;
            this.DTPRODUCTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTPRODUCTO_CellContentClick);
            // 
            // TXTProducto
            // 
            this.TXTProducto.Location = new System.Drawing.Point(305, 54);
            this.TXTProducto.Name = "TXTProducto";
            this.TXTProducto.Size = new System.Drawing.Size(175, 20);
            this.TXTProducto.TabIndex = 1;
            this.TXTProducto.TextChanged += new System.EventHandler(this.TXTProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(138, 346);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(75, 31);
            this.BTNNuevo.TabIndex = 3;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(305, 348);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(75, 33);
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "Ingresar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNIngresar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(542, 348);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 31);
            this.BTNCancelar.TabIndex = 5;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(405, 349);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 31);
            this.BTNEliminar.TabIndex = 6;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // FMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTProducto);
            this.Controls.Add(this.DTPRODUCTO);
            this.Name = "FMProducto";
            this.Text = "FMProducto";
            this.Load += new System.EventHandler(this.FMProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTPRODUCTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTPRODUCTO;
        private System.Windows.Forms.TextBox TXTProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNEliminar;
    }
}