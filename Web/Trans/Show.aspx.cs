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
namespace Web.transInfo
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
					string transDate= strid;
                    ;
					ShowInfo(DateTime.Parse(transDate));
				}
			}
		}
		
	private void ShowInfo(DateTime transDate)
	{
		BLL.transInfo bll=new BLL.transInfo();
		Model.transInfo model=bll.GetModel(transDate);
		this.lbltransDate.Text=model.transDate.ToString();
		this.lblcardID.Text=model.cardID;
		this.lbltransType.Text=model.transType;
		this.lbltransMoney.Text=model.transMoney.ToString();
		this.lblremark.Text=model.remark;

	}


    }
}
