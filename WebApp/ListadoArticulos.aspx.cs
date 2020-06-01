using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApp
{
    public partial class ListadoArticulos : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        public List<Categoria> listaCategorias { get; set; }
        public List<Marca> listaMarcas { get; set; }
        public Articulo articulo { get; set; }
        public List<Articulo> listaPedido { get; set; }

        public List<Articulo> listaArticulo { get; set; }

        public DataTable tabla = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listar();

                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                listaCategorias = categoriaNegocio.listar();

                MarcaNegocio marcaNegocio = new MarcaNegocio();
                listaMarcas = marcaNegocio.listar();


                listaArticulo = negocio.listar();

                listaPedido = (List<Articulo>)Session[Session.SessionID + "listaPedido"];

                if (Request.QueryString["idArt"] != null)
                {
                    var artSeleccionado = Convert.ToInt32(Request.QueryString["idArt"]);
                    articulo = listaArticulo.Find(J => J.Id == artSeleccionado);

                    //obtengo la lista de pedidos de la session
                    if (listaPedido == null)
                        listaPedido = new List<Articulo>();

                    listaPedido.Add(articulo);
                    Session[Session.SessionID + "listaPedido"] = listaPedido;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}