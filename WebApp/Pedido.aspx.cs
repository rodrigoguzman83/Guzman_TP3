using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebApp
{
    public partial class Pedido : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }

        public Carrito carrito { get; set; }
        public List<Articulo> listaArticulo { get; set; }
        public List<Articulo> listaPedido { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();

            try
            {
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

                Session["Error" + Session.SessionID] = ex;
                Response.Redirect("Error.aspx");
            }

        }
    }
}