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
			if(this.txtcurType.Text.Trim().Length==0)
			{
				strErr+="curType不能为空！\\n";	
			}
			if(this.txtsavingType.Text.Trim().Length==0)
			{
				strErr+="savingType不能为空！\\n";	
			}
	
			if(this.txtpass.Text.Trim().Length==0)
			{
				strErr+="pass不能为空！\\n";	
			}
		

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string cardID=this.txtcardID.Text;
			string curType=this.txtcurType.Text;
			string savingType=this.txtsavingType.Text;
			DateTime openDate=DateTime.Parse(this.txtopenDate.Text);
			decimal openMoney=decimal.Parse(this.txtopenMoney.Text);
			decimal balance=decimal.Parse(this.txtbalance.Text);
			string pass=this.txtpass.Text;
			bool IsReportLoss=this.chkIsReportLoss.Checked;
			int customerID=int.Parse(this.txtcustomerID.Text);

			Model.cardinfo model=new Model.cardinfo();
			model.cardID=cardID;
			model.curType=curType;
			model.savingType=savingType;
			model.openDate=openDate;
			model.openMoney=openMoney;
			model.balance=balance;
			model.pass=pass;
			model.IsReportLoss=IsReportLoss;
			model.customerID=customerID;

			BLL.cardinfo bll=new BLL.cardinfo();
			bll.Add(model);
			MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
