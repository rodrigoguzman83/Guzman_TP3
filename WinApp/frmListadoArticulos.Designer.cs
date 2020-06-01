namespace WinApp
{
    partial class frmListadoArticulos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoArticulos));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboCampos = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.rdbAscendente = new System.Windows.Forms.RadioButton();
            this.rdbDescendente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(213, 48);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(36, 38);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(649, 302);
            this.dgvArticulos.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvArticulos);
            this.groupBox1.Location = new System.Drawing.Point(46, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 370);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Articulos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboCampos);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Location = new System.Drawing.Point(46, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 101);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda Avanzada";
            // 
            // cboCampos
            // 
            this.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampos.FormattingEnabled = true;
            this.cboCampos.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Descripcion",
            "Categoria",
            "Marca"});
            this.cboCampos.Location = new System.Drawing.Point(36, 48);
            this.cboCampos.Name = "cboCampos";
            this.cboCampos.Size = new System.Drawing.Size(134, 21);
            this.cboCampos.TabIndex = 3;
            this.cboCampos.SelectedIndexChanged += new System.EventHandler(this.cboCampos_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExportarExcel);
            this.groupBox4.Controls.Add(this.btnVerDetalle);
            this.groupBox4.Controls.Add(this.btnModificar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Location = new System.Drawing.Point(798, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(82, 370);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbDescendente);
            this.groupBox3.Controls.Add(this.rdbAscendente);
            this.groupBox3.Location = new System.Drawing.Point(531, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenamiento";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExportarExcel.Image = global::WinApp.Properties.Resources.sobresalir;
            this.btnExportarExcel.Location = new System.Drawing.Point(18, 279);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(46, 40);
            this.btnExportarExcel.TabIndex = 8;
            this.toolTip5.SetToolTip(this.btnExportarExcel, "Exportar XLS");
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarPdf_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerDetalle.Image = global::WinApp.Properties.Resources.ver1;
            this.btnVerDetalle.Location = new System.Drawing.Point(18, 220);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(46, 40);
            this.btnVerDetalle.TabIndex = 7;
            this.toolTip4.SetToolTip(this.btnVerDetalle, "Ver Detalle Articulo");
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Image = global::WinApp.Properties.Resources._001_lapiz;
            this.btnModificar.Location = new System.Drawing.Point(19, 107);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(46, 40);
            this.btnModificar.TabIndex = 5;
            this.toolTip2.SetToolTip(this.btnModificar, "Modificar Articulo");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregar.Image = global::WinApp.Properties.Resources._002_mas;
            this.btnAgregar.Location = new System.Drawing.Point(19, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(46, 40);
            this.btnAgregar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar Articulo");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(19, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 40);
            this.btnEliminar.TabIndex = 6;
            this.toolTip3.SetToolTip(this.btnEliminar, "Eliminar Articulo");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rdbAscendente
            // 
            this.rdbAscendente.AutoSize = true;
            this.rdbAscendente.Location = new System.Drawing.Point(58, 48);
            this.rdbAscendente.Name = "rdbAscendente";
            this.rdbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rdbAscendente.TabIndex = 12;
            this.rdbAscendente.TabStop = true;
            this.rdbAscendente.Text = "Ascendente";
            this.rdbAscendente.UseVisualStyleBackColor = true;
            this.rdbAscendente.CheckedChanged += new System.EventHandler(this.rdbAscendente_CheckedChanged);
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(195, 51);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rdbDescendente.TabIndex = 13;
            this.rdbDescendente.TabStop = true;
            this.rdbDescendente.Text = "Descendente";
            this.rdbDescendente.UseVisualStyleBackColor = true;
            this.rdbDescendente.CheckedChanged += new System.EventHandler(this.rdbDescendente_CheckedChanged);
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(908, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoArticulos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ComboBox cboCampos;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.RadioButton rdbDescendente;
        private System.Windows.Forms.RadioButton rdbAscendente;
    }
}