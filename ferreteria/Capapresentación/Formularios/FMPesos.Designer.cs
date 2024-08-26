
namespace Capapresentación.Formularios
{
    partial class FMPesos
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
            this.TXTNamePeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPesos = new System.Windows.Forms.DataGridView();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.TXTLibra = new System.Windows.Forms.TextBox();
            this.TXTDetallesPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTPesos)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNamePeso
            // 
            this.TXTNamePeso.Location = new System.Drawing.Point(189, 36);
            this.TXTNamePeso.Name = "TXTNamePeso";
            this.TXTNamePeso.Size = new System.Drawing.Size(100, 20);
            this.TXTNamePeso.TabIndex = 0;
            this.TXTNamePeso.TextChanged += new System.EventHandler(this.BTNPesos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DTPesos
            // 
            this.DTPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTPesos.Location = new System.Drawing.Point(255, 94);
            this.DTPesos.Name = "DTPesos";
            this.DTPesos.Size = new System.Drawing.Size(276, 96);
            this.DTPesos.TabIndex = 2;
            this.DTPesos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTPesos_CellContentClick);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(226, 229);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(63, 27);
            this.BTNNuevo.TabIndex = 3;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(311, 230);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(61, 24);
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(391, 230);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 5;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(488, 230);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // TXTLibra
            // 
            this.TXTLibra.Location = new System.Drawing.Point(344, 36);
            this.TXTLibra.Name = "TXTLibra";
            this.TXTLibra.Size = new System.Drawing.Size(100, 20);
            this.TXTLibra.TabIndex = 7;
            this.TXTLibra.TextChanged += new System.EventHandler(this.TXTLibra_TextChanged);
            // 
            // TXTDetallesPeso
            // 
            this.TXTDetallesPeso.Location = new System.Drawing.Point(488, 36);
            this.TXTDetallesPeso.Name = "TXTDetallesPeso";
            this.TXTDetallesPeso.Size = new System.Drawing.Size(100, 20);
            this.TXTDetallesPeso.TabIndex = 8;
            this.TXTDetallesPeso.TextChanged += new System.EventHandler(this.TXTDetallesPeso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Libras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Detalle Peso";
            // 
            // FMPesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTDetallesPeso);
            this.Controls.Add(this.TXTLibra);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.DTPesos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNamePeso);
            this.Name = "FMPesos";
            this.Text = "FMPesos";
            this.Load += new System.EventHandler(this.FMPesos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTPesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNamePeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTPesos;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.TextBox TXTLibra;
        private System.Windows.Forms.TextBox TXTDetallesPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}