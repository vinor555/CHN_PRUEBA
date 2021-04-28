<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="chn_prueba.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link href="Recursos/css/Estilos.css" rel="stylesheet" /> 
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" />
</head>
<body>
    <div class="container well contenedor">

        <div class="row">
            <div class="col-xs-12">
                <h2>
                    CLIENTES
                </h2>
            </div>
        </div>
    
        <form id="form1" runat="server" class="form-horizontal">           
                 <div class="form-group">
                     <asp:Button ID="btnccrear" runat="server" Text="CREAR" OnClick="btnccrear_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                <div class="form-group">
                     <asp:Button ID="btnmodificar" runat="server" Text="MODIFICAR CLIENTE" OnClick="btnmodificar_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                <div class="form-group">
                     <asp:Button ID="btneliminar" runat="server" Text="ELIMINAR CLIENTE" OnClick="btneliminar_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
            <div class="form-group">
                     <asp:Button ID="btninicio" runat="server" Text="HOME" OnClick="btninicio_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                

                <div>

                </div>
                           
        </form>

    </div>
    </body>
</html>
