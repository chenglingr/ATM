﻿using System;
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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string cardID= Request.Params["id"];
					ShowInfo(cardID);
				}
			}
		}
			
	private void ShowInfo(string cardID)
	{
		BLL.cardinfo bll=new BLL.cardinfo();
		Model.cardinfo model=bll.GetModel(cardID);
		this.lblcardID.Text=model.cardID;
		this.txtcurType.Text=model.curType;
		this.txtsavingType.Text=model.savingType;
		this.txtopenDate.Text=model.openDate.ToString();
		this.txtopenMoney.Text=model.openMoney.ToString();
		this.txtbalance.Text=model.balance.ToString();
		this.txtpass.Text=model.pass;
		this.chkIsReportLoss.Checked=model.IsReportLoss;
		this.txtcustomerID.Text=model.customerID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			string cardID=this.lblcardID.Text;
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
			bll.Update(model);
			MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
