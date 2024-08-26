
namespace Capapresentación.Formularios
{
    partial class FMCategoria
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
            this.DTCategoria = new System.Windows.Forms.DataGridView();
            this.TXTCategoria = new System.Windows.Forms.TextBox();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // DTCategoria
            // 
            this.DTCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTCategoria.Location = new System.Drawing.Point(222, 100);
            this.DTCategoria.Name = "DTCategoria";
            this.DTCategoria.Size = new System.Drawing.Size(239, 130);
            this.DTCategoria.TabIndex = 0;
            this.DTCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTCategoria_CellContentClick);
            // 
            // TXTCategoria
            // 
            this.TXTCategoria.Location = new System.Drawing.Point(248, 58);
            this.TXTCategoria.Name = "TXTCategoria";
            this.TXTCategoria.Size = new System.Drawing.Size(146, 20);
            this.TXTCategoria.TabIndex = 1;
            this.TXTCategoria.TextChanged += new System.EventHandler(this.TXTCategoria_TextChanged);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(162, 282);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(80, 28);
            this.BTNNuevo.TabIndex = 2;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(261, 282);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(80, 28);
            this.BTNGuardar.TabIndex = 3;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(363, 282);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(80, 28);
            this.BTNEliminar.TabIndex = 4;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(462, 282);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(80, 28);
            this.BTNCancelar.TabIndex = 5;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoria";
            // 
            // FMCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.TXTCategoria);
            this.Controls.Add(this.DTCategoria);
            this.Name = "FMCategoria";
            this.Text = "FMCategoria";
            this.Load += new System.EventHandler(this.FMCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTCategoria;
        private System.Windows.Forms.TextBox TXTCategoria;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Label label1;
    }
}