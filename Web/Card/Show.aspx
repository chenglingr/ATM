<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Web.cardinfo.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="45" width="30%" align="right">
		卡号
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblcardID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		货币类型
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblcurType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		卡类型
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblsavingType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		开户日期
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblopenDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		开户金额
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblopenMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		余额
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblbalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		密码
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblpass" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		是否已挂失
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblIsReportLoss" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		客户号
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblcustomerID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




