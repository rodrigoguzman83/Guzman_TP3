using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace WinApp
{
    public partial class frmListadoArticulos : Form
    {
        private List<Articulo> lista;
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();
            frmArticulo.ShowDialog();
            cargarDatos();
        }

        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                lista = negocio.listarNuevo();
                dgvArticulos.DataSource = lista;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[6].Visible = false;

                if (dgvArticulos.Rows.Count > 0)
                {
                    rdbAscendente.Enabled = true;
                    rdbDescendente.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnExportarExcel.Enabled = true;
                    btnVerDetalle.Enabled = true;
                    cboCampos.Enabled = true;
                }
                else
                {
                    rdbAscendente.Enabled = false;
                    rdbDescendente.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnExportarExcel.Enabled = false;
                    btnVerDetalle.Enabled = false;
                    cboCampos.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;
            modificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmArticulo frmModificar = new frmArticulo(modificar);
            frmModificar.Text = "Modificar Articulo";
            frmModificar.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if(dgvArticulos.Rows.Count == 0)
                {
                    btnEliminar.Enabled = false;
                }

                var resp= MessageBox.Show("Esta seguro que quiere eliminar el articulo?","Eliminar articulo",MessageBoxButtons.YesNo);
                if (resp == DialogResult.No)
                {
                    return;
                }
                else
                {
                    int id = ((Articulo)dgvArticulos.CurrentRow.DataBoundItem).Id;
                    articuloNegocio.eliminar(id);
                    cargarDatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            List<Articulo> listaFiltrada;
            string campo = cboCampos.SelectedItem.ToString();
            try
            {
                
                if (txtBuscar.Text == "" || txtBuscar.Text.Length <=3)
                {
                    listaFiltrada = lista;
                    dgvArticulos.DataSource = listaFiltrada;

                }
                if (campo == "Codigo")
                {
                    listaFiltrada = lista.FindAll(k => k.Codigo.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                if (campo == "Nombre" && txtBuscar.Text.Length > 3)
                {
                    listaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                if (campo == "Descripcion" && txtBuscar.Text.Length > 3 )
                {
                    listaFiltrada = lista.FindAll(k => k.Descripcion.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                if (campo == "Categoria" && txtBuscar.Text.Length > 3)
                {
                    listaFiltrada = lista.FindAll(k => k.Categorias.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                if (campo == "Marca" && txtBuscar.Text.Length > 3)
                {
                    listaFiltrada = lista.FindAll(k => k.Marcas.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()));
                    dgvArticulos.DataSource = listaFiltrada;
                }
                //dgvArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampos.SelectedItem.ToString();
            if(campo == "Codigo")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Focus();
            }
            if (campo == "Nombre")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Focus();
            }
            if (campo == "Descripcion")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Focus();
            }
            if (campo == "Categoria")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Focus();
            }
            if (campo == "Marca")
            {
                cargarDatos();
                txtBuscar.Visible = true;
                txtBuscar.Focus();
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo mostrar;
            mostrar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalleArticulo frmDetalleArticulo = new frmDetalleArticulo(mostrar);
            frmDetalleArticulo.ShowDialog();
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.Rows.Count > 0)
            {
                ExportarExcel();
            }
            else
            {
                btnExportarExcel.Enabled = false;
            }
            
        }

        public void ExportarExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Articulos";
            // Cabeceras
            for (int i = 0; i < dgvArticulos.Columns.Count + 1; i++)
            {
                if (i > 0 && i < dgvArticulos.Columns.Count)
                {
                    worksheet.Cells[1, i + 1] = dgvArticulos.Columns[i].HeaderText;
                }
            }
            // Valores
            for (int i = 0; i < dgvArticulos.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvArticulos.Columns.Count; j++)
                {
                    if (j > 0 && j < dgvArticulos.Columns.Count)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvArticulos.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.FileName = "NombredeArchivoDefault";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }

        private void rdbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            listaFiltrada = lista.OrderBy(k => k.Precio).ToList();
            dgvArticulos.DataSource = listaFiltrada;
        }

        private void rdbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            listaFiltrada = lista.OrderByDescending(k => k.Precio).ToList();
            dgvArticulos.DataSource = listaFiltrada;
        }
    }
}
