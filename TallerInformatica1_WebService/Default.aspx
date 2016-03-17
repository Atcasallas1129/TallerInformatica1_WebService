<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TallerInformatica1_WebService.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Cálculo de sumatoria de dos numeros</h1>
        <table>
            <tr>
                <td><asp:Label ID="lblSolicitudPrimerNumero" runat = "server">Ingrese el primer número:</asp:Label></td>
                <td><asp:TextBox ID="TxtPrimerNumero" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSolicitudSegundoNumero" runat = "server">Ingrese el segundo número:</asp:Label></td>
                <td><asp:TextBox ID="TxtSegundoNUmero" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnCalculoSuma" runat="server" Text="Calcular Sumatoria" OnClick="btnCalculoSuma_Click" /></td>
                <td><asp:Label ID="LblResultado" runat="server" ForeColor="Red" Font-Size="XX-Large"></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
