
namespace Capapresentación.Formularios
{
    partial class FMMarcas
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
            this.TXTMarca = new System.Windows.Forms.TextBox();
            this.Marca = new System.Windows.Forms.Label();
            this.DTMarca = new System.Windows.Forms.DataGridView();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTMarca
            // 
            this.TXTMarca.Location = new System.Drawing.Point(342, 78);
            this.TXTMarca.Name = "TXTMarca";
            this.TXTMarca.Size = new System.Drawing.Size(84, 20);
            this.TXTMarca.TabIndex = 0;
            this.TXTMarca.TextChanged += new System.EventHandler(this.TXTMarca_TextChanged);
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(382, 55);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 1;
            this.Marca.Text = "Marca";
            // 
            // DTMarca
            // 
            this.DTMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTMarca.Location = new System.Drawing.Point(278, 113);
            this.DTMarca.Name = "DTMarca";
            this.DTMarca.Size = new System.Drawing.Size(218, 100);
            this.DTMarca.TabIndex = 2;
            this.DTMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTMarca_CellContentClick);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(255, 256);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(59, 29);
            this.BTNNuevo.TabIndex = 3;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(320, 256);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(59, 29);
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(385, 256);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(59, 29);
            this.BTNEliminar.TabIndex = 5;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(450, 256);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(59, 29);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // FMMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.DTMarca);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.TXTMarca);
            this.Name = "FMMarcas";
            this.Text = "FMMarcas";
            this.Load += new System.EventHandler(this.FMMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTMarca;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.DataGridView DTMarca;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}