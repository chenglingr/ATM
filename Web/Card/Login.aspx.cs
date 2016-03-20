using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Card
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            string cardID = this.txtcardID.Text;
            string pass = this.txtpass.Text;
            BLL.cardinfo bllc = new BLL.cardinfo();
            bool isOK=bllc.Exists(cardID, pass);
            if (isOK)
            {
                Session["CardID"] = cardID;
           

                MessageBox.ShowAndRedirect(this, "账号" + cardID + "登录成功", "Show.aspx");
           
            }
            else
            {
                MessageBox.Show(this, "账号" + cardID + "登录失败，请重试");
            }
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("../default.aspx");
        }
    }
}