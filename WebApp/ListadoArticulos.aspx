<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListadoArticulos.aspx.cs" Inherits="WebApp.ListadoArticulos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="margin-top:30px;">
        <div class="row">
            <!--Filtros-->
            <div class="col-lg-2">
                <h4 class="my-4">Categorias</h4>
                <% foreach (var cat in listaCategorias)
                    {%>
                <div class="list-group">
                    <a href="#" class="list-group-item"><%=cat.Nombre%></a>
                </div>
                <%}%>
                <h4 class="my-4">Marcas</h4>
                <% foreach (var marca in listaMarcas)
                    {%>
                <div class="list-group">
                    <a href="#" class="list-group-item"><%=marca.Nombre%></a>
                </div>
                <%}%>
            </div>
            <!--Listado de articulos-->
            <div class="col-lg-10">
                <div class="row">
                    <div class="card-deck">
                        <% foreach (var item in listaArticulos)
                            {%>

                        <div class="card" style="width: 18rem;">
                            <img class="card-img-top" src="<% = item.Imagen %>" alt="" style="width: 100%;">
                            <div class="card-body">
                                <h4 class="card-title"><% = item.Nombre %></h4>
                                <p class="card-text"><% = item.Descripcion %></p>
                                <h5>$<%=item.Precio%></h5>
                                <a class="btn btn-primary btn-sm" href="ListadoArticulos.aspx?idArt=<% = item.Id%>"><i class="fas fa-cart-plus">Agregar</i></a>
                                <a class="btn btn-dark btn-sm" href="Pedido.aspx?idArt=<%=item.Id%> & agrega=si">Detalle</a>
                            </div>
                        </div>
                        <%}%>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
