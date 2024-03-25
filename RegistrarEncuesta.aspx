<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarEncuesta.aspx.cs" Inherits="SistemaEncuesta.RegistrarEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar Encuesta</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
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
                            <a href="Reportes.aspx" class="nav-link">Reportes</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>


        <div class="container">

           <h2>Registrar encuesta</h2>

           <asp:Label ID="lblMensaje" runat="server" Visible="false" ForeColor="Red"></asp:Label>

           <div class="form-group">
           <asp:Label ID="lblNumeroEncuesta" runat="server"></asp:Label>
           </div>

           <div class="form-group">
               <label>Nombre: </label>
               <asp:TextBox ID="txtNombreEncuesta" runat="server" CssClass="form-control"></asp:TextBox>
           </div>

          <div class="form-group">
              <label>Apellido: </label>
              <asp:TextBox ID="txtApellidoEncuesta" runat="server" CssClass="form-control"></asp:TextBox>
          </div>

           <div class="form-group">
               <label>Fecha de nacimiento: </label>
               <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
           </div>

           <div class="form-group">
               <label>Correo electrónico: </label>
               <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
          </div>

            <div class="form-group">
                <label>¿Usted cuenta con carro propio? </label> 
                <asp:RadioButtonList ID="radioCarro" runat="server">
                              <asp:ListItem Text="Sí" value="true"></asp:ListItem> 
                              <asp:ListItem Text="No" value="false"></asp:ListItem> 
                </asp:RadioButtonList>
           </div>

           <asp:Button ID="btnGuardar" runat="server" Text="Enviar encuesta" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />      
        </div>

    </form>


    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js" integrity="sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s" crossorigin="anonymous"></script>


</body>
</html>
