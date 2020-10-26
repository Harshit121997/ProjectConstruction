<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CreateProject.aspx.cs" Inherits="ProjectConstruction.CreateProject" %>
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
                                <h4 class="card-title">CREATE PROJECT</h4>
                                <p class="text-muted m-b-15 f-s-12"><code> </code> </p>
                                <div class="basic-form">
                                    <form style="margin-left:10%" runat="server">
                                        <div class="form-group">
                                            <asp:Label ID="lblMessage" runat="server" ForeColor="red"></asp:Label><br />
                                            <asp:TextBox ID="txtProject" runat="server" class="form-control input-default" 
                                                placeholder="Project Name" style="width:40%"></asp:TextBox>
                                            <asp:Button ID="btnSaveProject" runat="server" OnClick="btnSaveProject_Click" Text="Save Project" class="btn mb-1 btn-primary" style="margin-top:6px" />
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
