
namespace Capapresentación.Formularios
{
    partial class FMTipos
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
            this.DTTipos = new System.Windows.Forms.DataGridView();
            this.TXTTipos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // DTTipos
            // 
            this.DTTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTTipos.Location = new System.Drawing.Point(273, 110);
            this.DTTipos.Name = "DTTipos";
            this.DTTipos.Size = new System.Drawing.Size(231, 104);
            this.DTTipos.TabIndex = 0;
            this.DTTipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTTipos_CellContentClick);
            // 
            // TXTTipos
            // 
            this.TXTTipos.Location = new System.Drawing.Point(316, 58);
            this.TXTTipos.Name = "TXTTipos";
            this.TXTTipos.Size = new System.Drawing.Size(122, 20);
            this.TXTTipos.TabIndex = 1;
            this.TXTTipos.TextChanged += new System.EventHandler(this.TXTTipos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(226, 251);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(69, 29);
            this.BTNNuevo.TabIndex = 3;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(352, 260);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(487, 265);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 5;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(589, 260);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // FMTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTTipos);
            this.Controls.Add(this.DTTipos);
            this.Name = "FMTipos";
            this.Text = "FMTipos";
            this.Load += new System.EventHandler(this.FMTipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTTipos;
        private System.Windows.Forms.TextBox TXTTipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}