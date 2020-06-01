namespace TP2_Guzman
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbpMenu = new System.Windows.Forms.GroupBox();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.gbpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpMenu
            // 
            this.gbpMenu.Controls.Add(this.btnArticulos);
            this.gbpMenu.Controls.Add(this.btnCategorias);
            this.gbpMenu.Controls.Add(this.btnMarcas);
            this.gbpMenu.Location = new System.Drawing.Point(82, 88);
            this.gbpMenu.Name = "gbpMenu";
            this.gbpMenu.Size = new System.Drawing.Size(516, 136);
            this.gbpMenu.TabIndex = 0;
            this.gbpMenu.TabStop = false;
            this.gbpMenu.Text = "Menu principal";
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(31, 47);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(111, 65);
            this.btnMarcas.TabIndex = 1;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(203, 47);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(111, 65);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(365, 47);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(111, 65);
            this.btnArticulos.TabIndex = 3;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 321);
            this.Controls.Add(this.gbpMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.gbpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpMenu;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
    }
}

