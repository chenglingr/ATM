<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Card.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="45" width="30%" align="right">
		卡号
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtcardID" runat="server" Width="200px" Text="1010357612121134"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="45" width="30%" align="right">
		密码
	：</td>
	<td height="45" width="*" align="left">
		<asp:TextBox id="txtpass"  TextMode="Password" MaxLength="6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	
</table>


            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="登录"
                   class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'" OnClick="btnSave_Click"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                  class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'" OnClick="btnCancle_Click"></asp:Button>
            </td>
        </tr>
    </table>
    <br />

</asp:Content>
