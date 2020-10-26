<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CreateSprint.aspx.cs" Inherits="ProjectConstruction.WebForm1" %>
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
                                <h4 class="card-title"> STATUS </h4>
                                <p class="text-muted m-b-15 f-s-12"><code> </code> </p>
                                <div class="basic-form">
                                    <form style="margin-left:10%" runat="server">
                                        <div class="form-group">
                                            <asp:Label ID="lblMessage" runat="server" ForeColor="red"></asp:Label><br />
                                            <asp:TextBox ID="txtProject" runat="server" class="form-control input-default" 
                                                placeholder="ProjectName" style="width:40%"></asp:TextBox>
                                            <br />
                                            <asp:TextBox ID="txtEmp" runat="server" class="form-control input-default" 
                                                placeholder="Employee Name" style="width:40%"></asp:TextBox>
                                        
                                            <br />
                                            <asp:DropDownList ID="DdlStatus" runat="server" placeholder="Status" 
                                                class="form-control input-default" style="width:40%">
                                                <asp:ListItem>------Select------</asp:ListItem>
                                               <asp:ListItem> To DO  </asp:ListItem>
                                               <asp:ListItem> In Progress  </asp:ListItem>
                                               <asp:ListItem> Done</asp:ListItem>
                                                </asp:DropDownList>
                                            <br />
                                            <asp:Button ID="btnCreate" runat="server" 
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
