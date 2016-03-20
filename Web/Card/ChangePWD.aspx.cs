using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Card
{
    public partial class ChangePWD : System.Web.UI.Page
    {
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (!Page.IsPostBack)
            {
                if (Session["CardID"] != null && Session["CardID"].ToString().Trim() != "")
                {
                    strid = Session["CardID"].ToString();
                                  
                }
                else
                {
                    MessageBox.ShowAndRedirect(this, "请先登录账户", "Login.aspx");
                }
            }
        }

        protected void Btnsub_Click(object sender, EventArgs e)
        {
            string old = txtold.Text;
            string new1 = txtnew1.Text;
            string new2 = txtnew2.Text;
            if (new1 == new2)
            {
                BLL.cardinfo bllc = new BLL.cardinfo();
                if (bllc.changePwd(strid, old, new1))
                {
                    Session["CardID"] = null;
                    MessageBox.ShowAndRedirect(this, "修改密码成功，请重新登录", "login.aspx");
                }
                else
                {
                    MessageBox.Show(this, "修改失败");
                }
            }
            else
            { MessageBox.Show(this,"两次密码不一致"); }
       
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../default.aspx");
        }
    }
}