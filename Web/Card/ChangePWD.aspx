<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePWD.aspx.cs" Inherits="Web.Card.ChangePWD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<div class="panel panel-default">
  <div class="panel-heading">
    <h3 class="panel-title">修改密码</h3>
  </div>
  <div class="panel-body">
      
      输入旧密码：<asp:TextBox ID="txtold" TextMode="Password" MaxLength="6" runat="server"></asp:TextBox><br /><br />
      输入新密码：<asp:TextBox ID="txtnew1" TextMode="Password" MaxLength="6" runat="server"></asp:TextBox><br /><br />
      确认新密码：<asp:TextBox ID="txtnew2" TextMode="Password" MaxLength="6" runat="server"></asp:TextBox><br /><br />
      <asp:Button ID="Btnsub" runat="server" Text="确认修改" OnClick="Btnsub_Click" />
       <asp:Button ID="btncancel" runat="server" Text="取消" OnClick="btncancel_Click" />
   </div>
</div>
</asp:Content>

