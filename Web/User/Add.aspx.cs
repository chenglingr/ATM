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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string customerName=this.txtcustomerName.Text;
			string pID=this.txtpID.Text;
			string telephone=this.txttelephone.Text;
			string address=this.txtaddress.Text;

			Model.userInfo model=new Model.userInfo();
			model.customerName=customerName;
			model.pID=pID;
			model.telephone=telephone;
			model.address=address;

			BLL.userInfo bll=new BLL.userInfo();
			bll.Add(model);
			MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
