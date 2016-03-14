<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Web.userInfo.Show" Title="显示页" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="45" width="30%" align="right">
		客户号
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblcustomerID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		客户姓名
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblcustomerName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		身份证号
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lblpID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		电话
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lbltelephone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		地址
	：</td>
	<td height="45" width="*" align="left">
		<asp:Label id="lbladdress" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




