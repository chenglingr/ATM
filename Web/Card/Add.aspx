<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Web.cardinfo.Add" Title="增加页" %>


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
		<asp:TextBox id="txtcardID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		货币类型
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtcurType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		卡类型
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtsavingType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		开户日期
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox ID="txtopenDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		开户金额
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtopenMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		余额
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtbalance" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		密码
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtpass" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		是否挂失
	：</td>
	<td height="45" width="*" align="left">
		<asp:CheckBox ID="chkIsReportLoss" Text="IsReportLoss" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		客户号
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtcustomerID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
