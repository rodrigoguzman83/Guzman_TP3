<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetallePedido.aspx.cs" Inherits="WebApp.DetallePedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Detalle del Pedido</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <!--FONTAWESOME-->
    <link
        rel="stylesheet"
        href="https://use.fontawesome.com/releases/v5.3.1/css/all.css"
        integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"
        crossorigin="anonymous" />
    <script
        src="https://kit.fontawesome.com/f66fe7d1b4.js"
        crossorigin="anonymous"></script>
</head>
<body>
    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">My Shopping Cart</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
    </nav>
    <h1>Detalle de la Compra</h1>
    <div class="container">
        <div class="row">
            <div class="col">
                <table class="table">
                    <tr>
                        <td>Nombre</td>
                        <td>Precio</td>
                        <td>Cantidad</td>
                        <td></td>
                        <td></td>
                        <td>Total</td>
                    </tr>
                    <%foreach (var item in listaPedido)
                        {
                    %>

                    <tr>
                        <td><% = item.Nombre %></td>
                        <td><% = item.Precio %></td>
                        <td>
                            <input type="text" class="form-control"></td>
                        <td><a id="btnIncremento<% = item.Id %>" class="btn btn-primary btn-lg" href="carritodecompras.aspx?idIncrementar=<% = item.Id %>" role="button">+</a></td>
                        <td><a id="btnDecremento<% = item.Id %>" class="btn btn-primary btn-lg" href="carritodecompras.aspx?idDecrementar=<% = item.Id %>" role="button">-</a></td>
                        <td><a href="DetallePedido.aspx?idQuitar=<% = item.Id.ToString() %>" class="btn btn-danger btn-lg">Quitar</a></td>
                        <td><a href="DetallePedido.aspx?idAgregar=<% = item.Id.ToString() %>" class="btn btn-primary btn-lg">Actualizar</a></td>
                        
                    </tr>
                    <% } %>
                </table>
            </div>
        </div>
    </div>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-sm">
                </div>
                <div class="col-sm">
                    <a href="ListadoArticulos.aspx" class="btn btn-primary btn-sm">Seguir Comprando</a>
                    <a href="#" class="btn btn-primary btn-sm">Vaciar Carrito</a>
                </div>
                <div class="col-sm">
                    Total a Pagar:$ <% = 10 %>
                </div>
            </div>
        </div>
    </section>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
