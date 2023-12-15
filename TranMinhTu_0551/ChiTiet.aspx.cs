using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TranMinhTu_0551
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        LopKetNoi connect = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string matuixach = Request.QueryString["mh"] + "";
            if(matuixach == "")
            {
                string sql = "select * from HANGHOA where MaHang=" + matuixach;
                dl_chitiet.DataSource = connect.laydulieu(sql);
                dl_chitiet.DataBind();
            }
            else
            {
                lbthongbao.Text = "Sản phẩm không tồn tại";
            }
        }

        protected void btMua_Click(object sender, EventArgs e)
        {
            string tenkhachhang = Session["username"] + "";
            if (tenkhachhang != "")
            {
                string matuixach = ((Button)sender).CommandArgument;

                Button bt_mua = (Button)sender;
                DataListItem item = (DataListItem)bt_mua.Parent;
                TextBox txtSL = (TextBox)item.FindControl("txt_soluong");
                string soluong = txtSL.Text;
                string sql = "";
                string sqlDL = "select * from DONHANG where MATUIXACH=" + matuixach + " AND TENKHACHHANG='" + tenkhachhang + "';";
                DataTable dt = connect.laydulieu(sqlDL);
                if (dt.Rows.Count > 0) sql = "UPDATE DONHANG SET SOLUONG=SOLUONG + " + soluong + " WHERE TENKHACHHANG='"
                         + tenkhachhang + "' AND MATUIXACH=" + matuixach + ";";
                else sql = "INSERT INTO DONHANG VALUES('" + tenkhachhang + "'," + matuixach + ",'" + soluong + "');";

                int ketqua = connect.CapNhat(sql);
                if (ketqua > 0) lbthongbao.Text = "Thành Công";
                else lbthongbao.Text = "Không thành công";
            }
            else
            {
                lbthongbao.Text = "Bạn phải đăng nhập";
            }
        }
    }
}