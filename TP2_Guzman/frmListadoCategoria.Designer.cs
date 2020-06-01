namespace Vistas
{
    partial class frmListadoCategoria
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
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Location = new System.Drawing.Point(34, 50);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarCategoria.TabIndex = 0;
            this.lblBuscarCategoria.Text = "Buscar:";
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Location = new System.Drawing.Point(103, 43);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(177, 20);
            this.txtBuscarCategoria.TabIndex = 1;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(301, 40);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCategoria.TabIndex = 2;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(37, 82);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(339, 150);
            this.dgvCategorias.TabIndex = 3;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(37, 264);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 4;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCategoria.Location = new System.Drawing.Point(172, 264);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 5;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(301, 264);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 6;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // frmListadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 309);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtBuscarCategoria);
            this.Controls.Add(this.lblBuscarCategoria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
    }
}