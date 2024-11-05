<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TiendasWeb.aspx.cs" Inherits="CRUD.TiendasWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Locales</h1>
            <table border="1">
                <thead>
                    <tr>
                        <th>No.</th>
                        <th>Nombre</th>
                        <th>Descripcion</th>
                        <th>Telefono</th>
                        <th>Estado</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="rptLocales" ItemType="CRUD.Locales" >
                        <ItemTemplate>
                            <tr>
                                <td><%# Container.ItemIndex + 1 %></td>
                                <td><%# Item.Nombre %></td>
                                <td><%# Item.Descripcion %></td>
                                <td><%# Item.Telefono %></td>
                                <td><%# Item.Estado %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
