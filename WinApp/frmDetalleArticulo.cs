using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinApp
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        //SOBREESCRIBO EL FORMULARIO PARA MOSTRAR EL DETALLE DEL ARTICULO
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                lblCodigoArticulo.Text = "CODIGO: " + articulo.Codigo;
                lblNombreArticulo.Text = "NOMBRE: " + articulo.Nombre;
                lblDescripcion.Text = "DESCRIPCION: " + articulo.Descripcion;
                lblCategoria.Text = "CATEGORIA: " + articulo.Categorias.Nombre;
                lblMarca.Text = "MARCA: " + articulo.Marcas.Nombre;
                picFotoArticulo.Load(articulo.Imagen);
                lblPrecio.Text = "PRECIO: $" +articulo.Precio.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
