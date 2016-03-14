<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Web.userInfo.Add" Title="增加页" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="45" width="30%" align="right">
		客户姓名
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtcustomerName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		身份证号
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtpID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		电话
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txttelephone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		住址
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtaddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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
