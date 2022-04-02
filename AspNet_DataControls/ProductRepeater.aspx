<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductRepeater.aspx.cs" Inherits="AspNet_DataControls.ProductRepeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rptProducts" runat="server">
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
                    <tr>
                        <td><%# Eval("UrunAdi")  %> </td>
                        <td><%# Eval("BirimFiyati")  %> </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                <AlternatingItemTemplate>
                    <tr style="background-color:lightgray">
                        <td><%# Eval("UrunAdi") %></td>
                        <td><%# Eval("BirimFiyati") %></td>
                    </tr>
                </AlternatingItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
