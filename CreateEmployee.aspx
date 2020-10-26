<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="ProjectConstruction.CreateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
     <div id="main-wrapper">
        <div class="content-body">
            <div class="container-fluid mt-3">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="card-title">CREATE EMPLOYEE</h4>
                                <p class="text-muted m-b-15 f-s-12"><code> </code> </p>
                                <div class="basic-form">
                                    <form style="margin-left:10%" runat="server">
                                        <div class="form-group">
                                            <asp:Label ID="lblMessage" runat="server" ForeColor="red"></asp:Label><br />
                                            <asp:TextBox ID="txtId" runat="server" class="form-control input-default" 
                                                placeholder="Employee Id" style="width:40%"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txtEmpName" runat="server" class="form-control input-default" 
                                                placeholder="Employee Name" style="width:40%"></asp:TextBox>
                                        
                                            <br />
                                            <asp:DropDownList ID="DdlDepartment" runat="server" placeholder="Department" 
                                                class="form-control input-default" style="width:40%">
                                                <asp:ListItem>------Select------</asp:ListItem>
                                               <asp:ListItem> Engineering  </asp:ListItem>
                                                </asp:DropDownList>
                                            <br />
                                            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click1" 
                                                class="btn mb-1 btn-primary" Text="Create" Style="margin-left:15%"> </asp:Button>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                    </div>
                </div>
            </div>
       </div>
</asp:Content>
