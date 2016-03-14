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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int customerID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(customerID);
				}
			}
		}
			
	private void ShowInfo(int customerID)
	{
		BLL.userInfo bll=new BLL.userInfo();
		Model.userInfo model=bll.GetModel(customerID);
		this.lblcustomerID.Text=model.customerID.ToString();
		this.txtcustomerName.Text=model.customerName;
		this.txtpID.Text=model.pID;
		this.txttelephone.Text=model.telephone;
		this.txtaddress.Text=model.address;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcustomerName.Text.Trim().Length==0)
			{
				strErr+="customerName不能为空！\\n";	
			}
			if(this.txtpID.Text.Trim().Length==0)
			{
				strErr+="pID不能为空！\\n";	
			}
			if(this.txttelephone.Text.Trim().Length==0)
			{
				strErr+="telephone不能为空！\\n";	
			}
			if(this.txtaddress.Text.Trim().Length==0)
			{
				strErr+="address不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int customerID=int.Parse(this.lblcustomerID.Text);
			string customerName=this.txtcustomerName.Text;
			string pID=this.txtpID.Text;
			string telephone=this.txttelephone.Text;
			string address=this.txtaddress.Text;


			Model.userInfo model=new Model.userInfo();
			model.customerID=customerID;
			model.customerName=customerName;
			model.pID=pID;
			model.telephone=telephone;
			model.address=address;

			BLL.userInfo bll=new BLL.userInfo();
			bll.Update(model);
			MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
