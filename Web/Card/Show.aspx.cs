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
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string cardID= strid;
					ShowInfo(cardID);
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
		this.lblopenMoney.Text=model.openMoney.ToString();
		this.lblbalance.Text=model.balance.ToString();
		this.lblpass.Text=model.pass;
		this.lblIsReportLoss.Text=model.IsReportLoss?"是":"否";
		this.lblcustomerID.Text=model.customerID.ToString();

	}


    }
}
