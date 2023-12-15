<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="TranMinhTu_0551.ChiTiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dl_chitiet" runat="server">
        <ItemTemplate>
            <table style="width:100%;">
                <tr>
                    <td rowspan="6">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "hinhanh/"+Eval("HINHANH") %>' />
                    </td>
                    <td>Tên:<asp:Label ID="Label1" runat="server" Text='<%# Eval("TENTUIXACH") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Mô tả:
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MOTA") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Số lượng:
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("SOLUONG") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Đơn giá:
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("DONGIA") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Số lượng:
                        <asp:TextBox ID="txt_soluong" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr style="display: flex; justify-content: space-between">
                    <td>
                       <asp:Button ID="btMua" runat="server" Text="Mua" CommandArgument='<%# Eval("MATUIXACH") %>' OnClick="btMua_Click" />
                    </td>
                    <td>
                        <p><a href="./GioHang.aspx">Giỏ Hàng</a></p>
                    </td>
                </tr>
                <tr>
                    <td>Đơn giá:
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:Label ID="lbthongbao" runat="server" Text="Label"></asp:Label>
</asp:Content>
