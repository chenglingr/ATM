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
namespace Web.userInfo
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
					int customerID=(Convert.ToInt32(strid));
					ShowInfo(customerID);
				}
			}
		}
		
	private void ShowInfo(int customerID)
	{
		BLL.userInfo bll=new BLL.userInfo();
		Model.userInfo model=bll.GetModel(customerID);
		this.lblcustomerID.Text=model.customerID.ToString();
		this.lblcustomerName.Text=model.customerName;
		this.lblpID.Text=model.pID;
		this.lbltelephone.Text=model.telephone;
		this.lbladdress.Text=model.address;

	}


    }
}
