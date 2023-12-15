using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TranMinhTu_0551
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        LopKetNoi connect = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string sql = "SELECT * FROM DANHMUC";
                DataList1.DataSource = connect.laydulieu(sql);
                DataList1.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string madanhmuc = ((LinkButton)sender).CommandArgument;
            Context.Items["mdm"] = madanhmuc;
            Server.Transfer("SanPham.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string strUserName = Login1.UserName;
            string password = Login1.Password;
            string sql = "select * from KHACHHANG where TENKHACHHANG='" + strUserName
                + "' and MATKHAU='" + password + "'";
            DataTable dt = connect.laydulieu(sql);
            if (dt.Rows.Count > 0)
            {
                Session["username"] = strUserName;
                Response.Redirect("SanPham.aspx");
            }
            else
            {
                Login1.FailureText = "Tên và mật khẩu không đúng";
            }
        }
    }
}