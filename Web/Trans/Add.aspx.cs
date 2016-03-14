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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
	
			if(this.txtcardID.Text.Trim().Length==0)
			{
				strErr+="cardID不能为空！\\n";	
			}
			if(this.txttransType.Text.Trim().Length==0)
			{
				strErr+="transType不能为空！\\n";	
			}
		
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime transDate=DateTime.Parse(this.txttransDate.Text);
			string cardID=this.txtcardID.Text;
			string transType=this.txttransType.Text;
			decimal transMoney=decimal.Parse(this.txttransMoney.Text);
			string remark=this.txtremark.Text;

			Model.transInfo model=new Model.transInfo();
			model.transDate=transDate;
			model.cardID=cardID;
			model.transType=transType;
			model.transMoney=transMoney;
			model.remark=remark;

			BLL.transInfo bll=new BLL.transInfo();
			bll.Add(model);
			MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
