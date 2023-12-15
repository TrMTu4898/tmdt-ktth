using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TranMinhTu_0551
{
    public partial class SanPham : System.Web.UI.Page
    {
        LopKetNoi connect = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string madanhmuc = Context.Items["ml"] + "";
            string sql = "";
            if (madanhmuc == "")
            {
                sql = "select * from TUIXACH";
            }
            else
                sql = "select * from TUIXACH where MATUIXACH='" + madanhmuc + "'";
            dl_sanpham.DataSource = connect.laydulieu(sql);
            dl_sanpham.DataBind();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string matuixach = ((ImageButton)sender).CommandArgument;
            Response.Redirect("ChiTiet.aspx?mh=" + matuixach);
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string matuixach = ((ImageButton)sender).CommandArgument;
            Response.Redirect("ChiTiet.aspx?mh=" + matuixach);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string matuixach = ((ImageButton)sender).CommandArgument;
            Response.Redirect("ChiTiet.aspx?mh=" + matuixach);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string matuixach = ((ImageButton)sender).CommandArgument;
            Response.Redirect("ChiTiet.aspx?mh=" + matuixach);
        }
    }
}