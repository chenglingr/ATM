<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Money.aspx.cs" Inherits="Web.Card.Money" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Literal ID="Litnews" runat="server" ></asp:Literal>
 <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
  <div class="panel panel-default">
    <div class="panel-heading" role="tab" id="headingOne">
      <h4 class="panel-title">
        <a role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
          存款
        </a>
      </h4>
    </div>
    <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
      <div class="panel-body">
        存款金额：
          <asp:TextBox ID="TxtAddMoney"  TextMode="Number" ToolTip="请输入存款金额" runat="server"></asp:TextBox>            
          <asp:Button ID="BtnAddMoney" CssClass="btn btn-default btn-sm" runat="server" Text="存款" OnClick="BtnAddMoney_Click" />   </div>
    </div>
  </div>
  <div class="panel panel-default">
    <div class="panel-heading" role="tab" id="headingTwo">
      <h4 class="panel-title">
        <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
          取款
        </a>
      </h4>
    </div>
    <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
      <div class="panel-body">
          取款金额：
          <asp:TextBox ID="TxtgetMoney"  TextMode="Number" ToolTip="请输入取款金额" runat="server"></asp:TextBox>            
          <asp:Button ID="BtngetMoney" CssClass="btn btn-default btn-sm" runat="server" Text="取款" OnClick="BtngetMoney_Click" />
        </div>
    </div>
  </div>
  <div class="panel panel-default">
    <div class="panel-heading" role="tab" id="headingThree">
      <h4 class="panel-title">
        <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
          转账
        </a>
      </h4>
    </div>
    <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
      <div class="panel-body">
         转入账号：<asp:TextBox ID="TxtCardID"  ToolTip="请输入对方账号" runat="server"></asp:TextBox>    
          <br />  <br />
          转账金额：
          <asp:TextBox ID="txtNum"  TextMode="Number" ToolTip="请输入转账金额" runat="server"></asp:TextBox> 
            <br />  <br />           
          <asp:Button ID="BtnZhuanZhang" CssClass="btn btn-default btn-sm" runat="server" Text="转账" OnClick="BtnZhuanZhang_Click" />
      
      </div>
    </div>
  </div>
</div>

</asp:Content>
