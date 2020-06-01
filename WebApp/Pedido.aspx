<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="WebApp.Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top: 20px;">
        <div class="row">
            <div class="col-lg-12">
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="ListadoArticulos.aspx">Articulos</a></li>
                        <li class="breadcrumb-item"><%=articulo.Categorias.Nombre%></li>
                        <li class="breadcrumb-item active"><%=articulo.Marcas.Nombre %></li>
                    </ol>
                </nav>
            </div>
        </div>
        <div class="container">
            <div class="jumbotron">
                <div class="row">
                    <div class="col-lg-8">
                        <div class="card" style="width: 18rem;">
                            <img class="card-img-top" src="<% = articulo.Imagen %>" alt="" style="width: 100%;">
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="card" style="width: 18rem;">
                            <div class="card-body">
                                <span class="badge badge-pill badge-primary"><%=articulo.Marcas.Nombre%></span>
                                <h5 class="card-title"><%=articulo.Nombre %></h5>
                                <p class="card-text"><strong>$<%=articulo.Precio %></strong></p>
                                <p class="card-text"><%=articulo.Descripcion %></p>
                                <a class="btn btn-primary btn-lg btn-block" href="Pedido.aspx?idArt=<% = articulo.Id%> &agrega=1"><i class="fas fa-cart-plus">Agregar</i></a>
                            </div>
                        </div>
                        <a class="btn btn-light btn-lg btn-block" href="ListadoArticulos.aspx">Seguir Comprando</a>
                        <a class="btn btn-dark btn-lg btn-block" href="DetallePedido.aspx">Ir al Listado</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
