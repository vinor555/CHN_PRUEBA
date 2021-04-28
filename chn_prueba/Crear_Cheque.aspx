<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Crear_Cheque.aspx.cs" Inherits="chn_prueba.Crear_Cheque" %>

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
                    CREAR CHEQUE
                </h2>
            </div>
        </div>
    
        <form id="form1" runat="server" class="form-horizontal">           
                 <div class="form-group">
                        <asp:Label ID="lblinicio" runat="server" Text="Correlativo Inicio" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtinicio" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                </div>
                <div class="form-group">
                        <asp:Label ID="lblfin" runat="server" Text="Correlativo Fin" CssClass="control-label col-sm-2"></asp:Label>
                        <div class="col-sm-12">
                        <asp:TextBox ID="txtfin" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblcheque" runat="server" Text="Numero Chequera" CssClass="control-label col-sm-2"></asp:Label>
                    <div class="col-sm-12">
                        <asp:DropDownList ID="cbb_cheque" runat="server" OnSelectedIndexChanged="cbb_chequera_SelectedIndexChanged" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>
                

                <div>

                </div>
                <div class="form-group">
                     <asp:Button ID="btncrearcheque" runat="server" Text="Crear Cheque" OnClick="btncrearchequera_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
            <div class="form-group">
                     <asp:Button ID="btninicio" runat="server" Text="HOME" OnClick="btninicio_Click" CssClass="form-control btn btn-primary"  ></asp:Button>
                </div>
                           
        </form>

    </div>
    </body>
</html>
