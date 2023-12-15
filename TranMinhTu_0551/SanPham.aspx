<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="TranMinhTu_0551.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Danh sách sản phẩm</h1>
<asp:DataList ID="dl_sanpham" runat="server" RepeatColumns="2" Width="233px">
    <ItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# "hinhanh/"+Eval("HINHANH") %>' CommandArgument='<%# Eval("MATUIXACH") %>' OnClick="ImageButton1_Click" />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("MATUIXACH") %>' OnClick="LinkButton2_Click" Text='<%# Eval("TENTUIXACH") %>'></asp:LinkButton>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Đơn giá: ">
        <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("MATUIXACH") %>' OnClick="LinkButton3_Click" Text='<%# Eval("DONGIA") %>'></asp:LinkButton>
        </asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Màu Sắc: ">
        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("MATUIXACH") %>' OnClick="LinkButton1_Click" Text='<%# Eval("MAUSAC") %>'></asp:LinkButton>
        </asp:Label>
    </ItemTemplate>
</asp:DataList>
</asp:Content>
