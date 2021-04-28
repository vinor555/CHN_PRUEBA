<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Crear_Cliente.aspx.cs" Inherits="chn_prueba.Principal" %>

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
                    CREAR CLIENTE
                </h2>
            </div>
        </div>
    
        <form id="form1" runat="server" class="form-horizontal">           
                 <div class="form-group">
                        <asp:Label ID="lblcui" runat="server" Text="CUI" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtcui" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblnombre" runat="server" Text="Nombre" CssClass="control-label col-sm-2"></asp:Label>
                    <div class="col-sm-12">
                            <asp:TextBox ID="txtnombre" runat="server"  CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblapellido" runat="server" Text="Apellido" CssClass="control-label col-sm-2"></asp:Label>
                    <div class="col-sm-12">
                            <asp:TextBox ID="txtapellido" runat="server"  CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lbldireccion" runat="server" Text="Direccion" CssClass="control-label col-sm-2"></asp:Label>
                    <div class="col-sm-12">
                        <asp:TextBox ID="txtdireccion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lbltelefono" runat="server" Text="Telefono" CssClass="control-label col-sm-2"></asp:Label>
                    <div class="col-sm-12">
                        <asp:TextBox ID="txttelefono" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div>

                </div>
                <div class="form-group">
                     <asp:Button ID="btncrear" runat="server" Text="Crear Cliente" OnClick="btncrear_Click" CssClass="form-control btn btn-primary" ></asp:Button>
                    
                </div>       
            <div class="form-group">
                     <asp:Button ID="btninicio" runat="server" Text="HOME" OnClick="btninicio_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                    
                           
                       
                           
        </form>

    </div>
</body>
</html>
