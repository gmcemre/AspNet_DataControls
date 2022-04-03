<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductRepeater.aspx.cs" Inherits="AspNet_DataControls.ProductRepeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Repeater</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptProducts" runat="server" OnItemDataBound="rptProducts_ItemDataBound" OnItemCommand="rptProducts_ItemCommand">
                <HeaderTemplate>
                    <table border="1">
                        <thead>
                            <tr>
                                <th>Ürün Adı</th>
                                <th>Birim Fiyatı</th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr id="satir" runat="server">
                        <td><%# Eval("UrunAdi")  %> </td>
                        <td><%# Eval("BirimFiyati")  %> </td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Sil" CommandArgument='<%# Eval("UrunID") %>'>Sil</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Duzenle" CommandArgument='<%# Eval("UrunID") %>'>Düzenle</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                <AlternatingItemTemplate>
                    <tr id="satir" runat="server" style="background-color: lightgray">
                        <td><%# Eval("UrunAdi") %></td>
                        <td><%# Eval("BirimFiyati") %></td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Sil" CommandArgument='<%# Eval("UrunID") %>'>Sil</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Duzenle" CommandArgument='<%# Eval("UrunID") %>'>Düzenle</asp:LinkButton>
                        </td>
                    </tr>
                </AlternatingItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
