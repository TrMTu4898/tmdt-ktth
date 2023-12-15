using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TranMinhTu_0551
{
    public partial class GioHang : System.Web.UI.Page
    {
        LopKetNoi connect = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string tenkhachhang = Session["username"] + "";
            if (tenkhachhang != "")
            {
                string sql = "SELECT TUIXACH.TENTUIXACH, TUIXACH.MAUSAC, TUIXACH.DONGIA, DONHANG.SOLUONG, (TUIXACH.DONGIA * DONHANG.SOLUONG) AS THANHTIEN" +
                    "FROM DONHANG JOIN TUIXACH ON DONHANG.MATUIXACH = TUIXACH.MATUIXACH"+
                    "JOIN KHACHHANG ON DONHANG.TENKHACHHANG = KHACHHANG.TENKHACHHANG"+
                    "WHERE KHACHHANG.TENKHACHHANG ='"+tenkhachhang+ "'";
                GridView1.DataSource = connect.laydulieu(sql);
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string tenkhachhang = Session["username"] + "";
            if (tenkhachhang != "")
            {
                Button bt = (Button)sender;
                string matuixach = bt.CommandArgument;
                GridViewRow gr = (GridViewRow)bt.Parent.Parent;
                string soluong = ((TextBox)gr.FindControl("TextBox1")).Text;

                string sql = "UPDATE DONHANG SET SOLUONG=" + soluong + " WHERE TENKHACHANG='"
                        + tenkhachhang + "' AND MATUIXACH=" + matuixach + ";";

                int kq = connect.CapNhat(sql);

                if (kq > 0) lb_thongbao.Text = "Sửa thành công";
                else lb_thongbao.Text = "Sửa không thành công";
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string tenkhachhang = Session["username"] + "";
            if (tenkhachhang != "")
            {
                string matuixach = ((LinkButton)sender).CommandArgument;

                string sql = "DELETE DONHANG WHERE TENKHACHHANG='" + tenkhachhang + "' AND MATUIXACH=" + matuixach;
                int kq = connect.CapNhat(sql);

                if (kq > 0) lb_thongbao.Text = "Xóa thành công";
                else lb_thongbao.Text = "Xóa không thành công";
            }
        }
    }
}