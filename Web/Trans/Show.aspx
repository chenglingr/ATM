<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Web.transInfo.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="45" width="30%" align="right">
		交易日期
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lbltransDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		卡号
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblcardID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		交易类型
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lbltransType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		交易金额
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lbltransMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		备注
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblremark" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




