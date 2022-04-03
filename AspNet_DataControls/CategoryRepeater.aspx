<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryRepeater.aspx.cs" Inherits="AspNet_DataControls.CategoryRepeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptKategori" runat="server" OnItemCommand="rptKategori_ItemCommand">
                <HeaderTemplate>
                    <table border="1">
                        <thead>
                            <tr>
                                <th>Kategori Adı</th>
                                <th>Açıklama</th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("KategoriAdi") %></td>
                        <td><%# Eval("Tanimi") %></td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Sil" CommandArgument='<%# Eval("KategoriID") %>'>Sil</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
