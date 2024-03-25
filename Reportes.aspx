<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="SistemaEncuesta.Reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Reporte</title>
     
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
</head>
<body>
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">

            <div class="container">
                <a href="#" class="navbar-brand">Sistema Encuestas</a>
                  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                   </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item">
                            <a href="RegistrarEncuesta.aspx" class="nav-link">Registrar Encuesta</a>
                        </li>
                        <li class="nav-item">
                            <a href="Reportes.aspx" class="nav-link">Reporte</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Reportes</h2>
            <table class="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>Encuestas realizadas</th>
                        <th>Personas con carro propio</th>
                        <th>Personas sin carro propio</th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td><asp:label ID="lblCantidadEncuestas" runat="server"></asp:label></td>
                        <td><asp:label ID="lblPersonasCarroPropio" runat="server"></asp:label></td>
                        <td><asp:label ID="lblPersonasSinCarroPropio" runat="server"></asp:label></td>
                        <asp:label ID="lblMensajeError" runat="server" ForeColor="Red" Visible="False"></asp:label>
                    </tr>
                </tbody>                      
            </table>
        </div>
    </form>

<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js" integrity="sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s" crossorigin="anonymous"></script>

</body>
</html>