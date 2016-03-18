using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CardID"] != null)//已登录
                {
                    LabelCardID.Visible = true;
                    HyperLinkOut.Visible = true;
                    HyperLinkPass.Visible = true;

                    LabelCardID.Text = Session["CardID"].ToString();

                    HLLogin.Visible = false;
                    HLADD.Visible = false;
                }
                else
                {
                    LabelCardID.Visible =false;
                    HyperLinkOut.Visible = false;
                    HyperLinkPass.Visible = false;

                    LabelCardID.Text = "";

                    HLLogin.Visible = true;
                    HLADD.Visible = true;
                }
            }
        }

        protected void HyperLinkOut_Click(object sender, EventArgs e)
        {
            Session["CardID"] = null;
            LabelCardID.Visible = false;
            HyperLinkOut.Visible = false;
            HyperLinkPass.Visible = false;

            LabelCardID.Text = "";

            HLLogin.Visible = true;
            HLADD.Visible = true;

          //   Response.Redirect("../ Default.aspx");
          Server.Transfer ("../Default.aspx");
        }
    }
}