using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Card
{
    public partial class Money : System.Web.UI.Page
    {
        private string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //  if (!Page.IsPostBack)
             Litnews.Text = "";
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

        protected void BtnAddMoney_Click(object sender, EventArgs e)
        {
            decimal num = decimal.Parse(TxtAddMoney.Text);
            BLL.cardinfo bll = new BLL.cardinfo();
            string xx = strid;
            if (bll.UpdateBalance(strid, num))
            {
                Litnews.Text = "存款成功";
            }
            else
            { Litnews.Text = "存款失败"; }
            TxtAddMoney.Text = "";
        }

        protected void BtngetMoney_Click(object sender, EventArgs e)
        {
            decimal num = decimal.Parse(TxtgetMoney.Text);
            BLL.cardinfo bll = new BLL.cardinfo();
            if (bll.UpdateBalance(strid, -num))
            {
                Litnews.Text = "取款成功";
            }
            else
            { Litnews.Text = "取款失败"; }
            TxtgetMoney.Text = "";
        }

        protected void BtnZhuanZhang_Click(object sender, EventArgs e)
        {
            string cardin = TxtCardID.Text;
            decimal num = decimal.Parse(txtNum.Text);
            BLL.cardinfo bll = new BLL.cardinfo();
           if( bll.ZhuanZhang(strid,cardin,num))
            {
                Litnews.Text = "转账成功";
            }
            else
            { Litnews.Text = "转账失败"; }
        }
    }
}