<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina_Principal.aspx.cs" Inherits="chn_prueba.Pagina_Principal" %>

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
                    HOME
                </h2>
            </div>
        </div>
    
        <form id="form1" runat="server" class="form-horizontal">           
                 <div class="form-group">
                     <asp:Button ID="btnclientes" runat="server" Text="CLIENTES" OnClick="btnclientes_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                <div class="form-group">
                     <asp:Button ID="btncuentas" runat="server" Text="CUENTAS" OnClick="btncuentas_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                <div class="form-group">
                     <asp:Button ID="btnchequeras" runat="server" Text="CHEQUERAS" OnClick="btncrearchequera_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                

                <div>

                </div>
                <div class="form-group">
                     <asp:Button ID="btncheques" runat="server" Text="CHEQUES" OnClick="btncheques_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
            <div class="form-group">
                     <asp:Button ID="btndatos" runat="server" Text="MOSTRAR DATOS" OnClick="btndatos_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                           
        </form>

    </div>
    </body>
</html>
