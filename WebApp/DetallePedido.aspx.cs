using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace WebApp
{
    public partial class DetallePedido : System.Web.UI.Page
    {
        public List<Articulo> listaPedido { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                listaPedido = (List<Articulo>)Session[Session.SessionID + "listaPedido"];

                var pokeQuitar = Request.QueryString["idQuitar"];
                if (pokeQuitar != null)
                {
                    Articulo artEliminar = listaPedido.Find(J => J.Id == int.Parse(pokeQuitar));
                    listaPedido.Remove(artEliminar);
                    Session[Session.SessionID + "listaPedido"] = listaPedido;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}