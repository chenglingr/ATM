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

//([savingType]='定期' OR [savingType]='定活两便' OR [savingType]='活期')
namespace Web.userInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr1="";
			if(this.txtcustomerName.Text.Trim().Length==0)
			{
				strErr1+="customerName不能为空！\\n";	
			}
			if(this.txtpID.Text.Trim().Length==0)
			{
				strErr1+="pID不能为空！\\n";	
			}
			if(this.txttelephone.Text.Trim().Length==0)
			{
				strErr1+="telephone不能为空！\\n";	
			}
			if(this.txtaddress.Text.Trim().Length==0)
			{
				strErr1+="address不能为空！\\n";	
			}

			if(strErr1!="")
			{
				MessageBox.Show(this,strErr1);
				return;
			}
			string customerName=this.txtcustomerName.Text;
			string pID=this.txtpID.Text;
			string telephone=this.txttelephone.Text;
			string address=this.txtaddress.Text;

			Model.userInfo model1=new Model.userInfo();
			model1.customerName=customerName;
			model1.pID=pID;
			model1.telephone=telephone;
			model1.address=address;

		

            //
            string strErr = "";
         
        

            if (this.txtpass.Text.Trim().Length == 0)
            {
                strErr += "pass不能为空！\\n";
            }


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string cardID = "";
            string curType =this.DropDownListcurType.SelectedValue;
            string savingType =this.DropDownListsavingType.SelectedValue;
            DateTime openDate = DateTime.Now;
            decimal openMoney = decimal.Parse(this.txtopenMoney.Text);
            decimal balance = openMoney;
            string pass = this.txtpass.Text;
            bool IsReportLoss =false;
            int customerID =0;

            Model.cardinfo model = new Model.cardinfo();
            model.cardID = cardID;
            model.curType = curType;
            model.savingType = savingType;
            model.openDate = openDate;
            model.openMoney = openMoney;
            model.balance = balance;
            model.pass = pass;
            model.IsReportLoss = IsReportLoss;
            model.customerID = customerID;

            BLL.Atm bll = new BLL.Atm();
            string CardID=  bll.Add(model1,model);
            

            MessageBox.ShowAndRedirect(this, "开户成功！卡号为:"+CardID, "add.aspx");

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
          
             Response.Redirect("list.aspx");
        }
    }
}
