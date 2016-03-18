using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Web.cardinfo
{
    public partial class Show : Page
    {        
        public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
                if (Session["CardID"] != null && Session["CardID"].ToString().Trim() != "")
                {
                    strid = Session["CardID"].ToString();
                    string cardID = strid;
                    ShowInfo(cardID);
                }
                else
                {
                    MessageBox.ShowAndRedirect(this, "请先登录账户", "Login.aspx");
                }
			}
		}
		
	private void ShowInfo(string cardID)
	{
		BLL.cardinfo bll=new BLL.cardinfo();
		Model.cardinfo model=bll.GetModel(cardID);
		this.lblcardID.Text=model.cardID;
		this.lblcurType.Text=model.curType;
		this.lblsavingType.Text=model.savingType;
		this.lblopenDate.Text=model.openDate.ToString();
	
		this.lblbalance.Text=model.balance.ToString();
	
		this.lblIsReportLoss.Text=model.IsReportLoss?"是":"否";
	

	}


    }
}
