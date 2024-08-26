
namespace Capapresentación.Formularios
{
    partial class FMModelos
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
            this.TXTModelo = new System.Windows.Forms.TextBox();
            this.Modelos = new System.Windows.Forms.Label();
            this.DTModelo = new System.Windows.Forms.DataGridView();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTModelo
            // 
            this.TXTModelo.Location = new System.Drawing.Point(332, 48);
            this.TXTModelo.Name = "TXTModelo";
            this.TXTModelo.Size = new System.Drawing.Size(104, 20);
            this.TXTModelo.TabIndex = 0;
            this.TXTModelo.TextChanged += new System.EventHandler(this.TXTModelo_TextChanged);
            // 
            // Modelos
            // 
            this.Modelos.AutoSize = true;
            this.Modelos.Location = new System.Drawing.Point(351, 22);
            this.Modelos.Name = "Modelos";
            this.Modelos.Size = new System.Drawing.Size(47, 13);
            this.Modelos.TabIndex = 1;
            this.Modelos.Text = "Modelos";
            // 
            // DTModelo
            // 
            this.DTModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTModelo.Location = new System.Drawing.Point(264, 98);
            this.DTModelo.Name = "DTModelo";
            this.DTModelo.Size = new System.Drawing.Size(231, 92);
            this.DTModelo.TabIndex = 2;
            this.DTModelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTModelo_CellContentClick);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(208, 224);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(75, 23);
            this.BTNNuevo.TabIndex = 3;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(311, 224);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(61, 23);
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(402, 224);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 5;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(494, 224);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(64, 23);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // FMModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.DTModelo);
            this.Controls.Add(this.Modelos);
            this.Controls.Add(this.TXTModelo);
            this.Name = "FMModelos";
            this.Text = "FMModelos";
            this.Load += new System.EventHandler(this.FMModelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTModelo;
        private System.Windows.Forms.Label Modelos;
        private System.Windows.Forms.DataGridView DTModelo;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}