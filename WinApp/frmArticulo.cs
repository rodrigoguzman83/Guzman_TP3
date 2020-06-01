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

namespace WinApp
{
    public partial class frmArticulo : Form
    {
        private Articulo articulo;
        public frmArticulo()
        {
            InitializeComponent();
        }

        //SOBREESCRIBO EL FORMULARIO DE ALTA PARA USARLO EN LA MODIFICACION
        public frmArticulo( Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> lista = new List<Articulo>();
            List<Articulo> listaFiltrada;

            //Articulo articulo = new Articulo();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                //VALIDACIONES
                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
                {
                    MessageBox.Show("Debe ingresar el CODIGO DEL ARTICULO", "Alta de Articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    return;                    
                }

                //VALIDO QUE NO EXISTA EL CODIGO YA
                /*lista = articuloNegocio.listarNuevo();
                listaFiltrada = lista.FindAll(k => k.Codigo.ToLower().Contains(txtCodigo.Text.ToLower()));
                if (listaFiltrada.Count >= 1)
                {
                    MessageBox.Show("Ya existe ese CODIGO DE ARTICULO", "Alta de Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Focus();
                    return;
                }*/

                if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe ingresar el NOMBRE DEL ARTICULO", "Alta de Articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                if (cboMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir la MARCA DEL ARTICULO", "Alta de Articulo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    cboMarca.Focus();
                    return;
                }

                if (cboCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir la CATEGORIA DEL ARTICULO", "Alta de Articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCategoria.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Debe ingresar el PRECIO DEL ARTICULO", "Alta de Articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    return;
                }

                articulo.Codigo = txtCodigo.Text.Trim();
                articulo.Nombre = txtNombre.Text.Trim();
                articulo.Descripcion = txtDescripcion.Text.Trim();
                articulo.Categorias = (Categoria)cboCategoria.SelectedItem;
                articulo.Marcas= (Marca)cboMarca.SelectedItem;
                articulo.Imagen = txtImagen.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    articuloNegocio.Modificar(articulo);
                    MessageBox.Show("Su articulo fue modificado con exito", "Articulos");
                }   
                else
                {
                    articuloNegocio.Agregar(articulo);
                    MessageBox.Show("Su articulo fue dado de alta con exito", "Articulos");
                }
                    

                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.SelectedIndex = -1;

                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Nombre";
                cboMarca.SelectedIndex = -1;

                //PARA LA MODIFICACION
                //CARGO LOS DATOS DEL OBJETO EN CADA UNO DE LOS COMPONENTES DEL FORM
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboCategoria.SelectedValue = articulo.Categorias.Id;
                    cboMarca.SelectedValue = articulo.Marcas.Id;
                    txtImagen.Text = articulo.Imagen;
                    txtPrecio.Text = articulo.Precio.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar == 46)

            {
                if ( e.KeyChar != 8)

                {
                    e.Handled = true;
                }
            }
        }
    }
}
