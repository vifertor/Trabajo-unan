
namespace Capapresentación.Formularios
{
    partial class FMAcabados
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
            this.DTAcabados = new System.Windows.Forms.DataGridView();
            this.TXTAcabados = new System.Windows.Forms.TextBox();
            this.Acabados = new System.Windows.Forms.Label();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTAcabados)).BeginInit();
            this.SuspendLayout();
            // 
            // DTAcabados
            // 
            this.DTAcabados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTAcabados.Location = new System.Drawing.Point(306, 86);
            this.DTAcabados.Name = "DTAcabados";
            this.DTAcabados.Size = new System.Drawing.Size(222, 99);
            this.DTAcabados.TabIndex = 0;
            this.DTAcabados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTAcabados_CellContentClick);
            // 
            // TXTAcabados
            // 
            this.TXTAcabados.Location = new System.Drawing.Point(355, 42);
            this.TXTAcabados.Name = "TXTAcabados";
            this.TXTAcabados.Size = new System.Drawing.Size(100, 20);
            this.TXTAcabados.TabIndex = 1;
            this.TXTAcabados.TextChanged += new System.EventHandler(this.TXTAcabados_TextChanged);
            // 
            // Acabados
            // 
            this.Acabados.AutoSize = true;
            this.Acabados.Location = new System.Drawing.Point(382, 26);
            this.Acabados.Name = "Acabados";
            this.Acabados.Size = new System.Drawing.Size(55, 13);
            this.Acabados.TabIndex = 2;
            this.Acabados.Text = "Acabados";
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(251, 240);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(72, 31);
            this.BTNNuevo.TabIndex = 3;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(355, 240);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(72, 31);
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(446, 241);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(72, 29);
            this.BTNEliminar.TabIndex = 5;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(539, 240);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(72, 31);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // FMAcabados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.Acabados);
            this.Controls.Add(this.TXTAcabados);
            this.Controls.Add(this.DTAcabados);
            this.Name = "FMAcabados";
            this.Text = "FMAcabados";
            this.Load += new System.EventHandler(this.FMAcabados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTAcabados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTAcabados;
        private System.Windows.Forms.TextBox TXTAcabados;
        private System.Windows.Forms.Label Acabados;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}