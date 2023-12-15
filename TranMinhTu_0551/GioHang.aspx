<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="TranMinhTu_0551.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>DANH SÁCH SẢN PHẨM</h2>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="TENTUIXACH" HeaderText="Sản Phẩm" />
            <asp:BoundField DataField="MAUSAC" HeaderText="Màu Sắc" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn Giá" />
            <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("SOLUONG") %>'></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("MATUIXACH") %>' OnClick="Button1_Click" Text="Sửa" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ThanhTien" HeaderText="Thành tiền" />
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("MATUIXACH") %>' OnClick="LinkButton2_Click">Xóa</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="lb_thongbao" runat="server" Text="Label"></asp:Label>
</asp:Content>
