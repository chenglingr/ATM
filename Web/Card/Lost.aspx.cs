using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Card
{
    public partial class Lost : System.Web.UI.Page
    {
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
          //  if (!Page.IsPostBack)
            {
                if (Session["CardID"] != null && Session["CardID"].ToString().Trim() != "")
                {
                    strid = Session["CardID"].ToString();
                    string cardID = strid;
                    BLL.cardinfo bllc = new BLL.cardinfo();
                    if (bllc.getState(cardID))
                    {
                        ButtonGua.Text="取消挂失";
                      
                    }
                    else
                    {
                        ButtonGua.Text = "我要挂失";

                    }
                }
                else
                {
                    MessageBox.ShowAndRedirect(this, "请先登录账户", "Login.aspx");
                }
            }
        }

        protected void ButtonGua_Click(object sender, EventArgs e)
        {
            BLL.cardinfo bllc = new BLL.cardinfo();
           if( bllc.ChangeState(strid))
            {
                if (ButtonGua.Text == "取消挂失")
                {
                    ButtonGua.Text = "我要挂失";
                }
                else
                { ButtonGua.Text = "取消挂失"; }
                MessageBox.Show(this,"状态改变成功");
              
            }
        }

      
    }
}