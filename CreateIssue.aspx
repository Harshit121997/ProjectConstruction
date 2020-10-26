<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CreateIssue.aspx.cs" Inherits="ProjectConstruction.CreateIssue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
<div id="main-wrapper">
        <div class="content-body">
            <div class="container-fluid mt-3">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-body">
                                <h3 class="card-title"> CREATE ISSUE</h3>
                                <p class="text-muted m-b-15 f-s-12"><code> </code> </p>
                                <div class="basic-form">
                                   <form style="margin-left:10%; line-height:50px; color:black;" runat="server">
                                        <div class="form-group">
                                            <asp:Label ID="lblMessage" runat="server" ForeColor="red"></asp:Label><br />
                                             <label for="Project">Project</label>
                                            <asp:DropDownList ID="DdlProject" runat="server" placeholder="" style="width:50%; 
                                            border-radius:4px; height:40px; margin-left:5%;" ></asp:DropDownList>
                                            <br/>
                                              <label for="Issue Type">IssueType</label>
                                           <asp:DropDownList ID="DdlIssue" runat="server" placeholder="" style="width:50%; 
                                            border-radius:4px; height:40px; margin-left:3%;" >
                                               <asp:ListItem>------Select------</asp:ListItem>
                                               <asp:ListItem> Bug </asp:ListItem>
                                               <asp:ListItem> Enhancement </asp:ListItem>
                                               <asp:ListItem> Story </asp:ListItem>
                                               <asp:ListItem> Task </asp:ListItem>
                                               <asp:ListItem> Test </asp:ListItem>
                                           </asp:DropDownList>
                                            <br/>
                                            Epic Name
                                            &nbsp;<asp:TextBox ID="txtEpicName" runat="server" placeholder="" style="width:60%; 
                                            border-radius:4px; height:40px; margin-left:2%;" ></asp:TextBox> 
                                            <br/>
                                             <label style="margin-left:11%; color:red">Provide a short name to identify this epic </label>
                                            <br/>
                                             Summary
                                              <asp:TextBox ID="txtSummary" runat="server" style="width:60%; 
                                              border-radius:4px; height:40px; margin-left:3%;"></asp:TextBox><br/>
                                            <br />
                                            Description
                                               <textarea runat="server"  ID="txtDescription" rows="3" cols="45" 
                                                style="border-radius:4px; margin-left:2%;"></textarea>
                                                  <br/>
                                                  Assign&nbsp
                                                <asp:DropDownList ID="DdlAssign" runat="server" placeholder="Project Name" 
                                                    style="width:50%; border-radius:4px; height:40px; margin-left:5%;" ></asp:DropDownList> 
                                            <br/>
                                                  <label for="Priority">Priority</label>
                                            <asp:DropDownList ID="DdlPriority" runat="server" placeholder="Project Name" 
                                            style="width:50%; border-radius:4px; height:40px; margin-left:5%;" >
                                                <asp:ListItem>------Select------</asp:ListItem>
                                                <asp:ListItem> P1-Normal </asp:ListItem>
                                                <asp:ListItem> P2-High</asp:ListItem>
                                                <asp:ListItem> P3-Medium </asp:ListItem>
                                                <asp:ListItem> P4-Low </asp:ListItem>
                                                <asp:ListItem> P5-Blocker </asp:ListItem>
                                                <asp:ListItem> P6-Urgent </asp:ListItem>
                                            </asp:DropDownList>
                                            <br />
                                            Status
                                            <asp:DropDownList ID="ddlStatus" runat="server" placeholder="Status" 
                                            style="width:50%; border-radius:4px; height:40px; margin-left:50px;" >
                                                <asp:ListItem>------Select------</asp:ListItem>
                                                <asp:ListItem> To Do </asp:ListItem>
                                                <asp:ListItem> In Progress </asp:ListItem>
                                                <asp:ListItem> Done </asp:ListItem>
                                            </asp:DropDownList>
                                            <br/><br/>
                                               <table style="margin-left:63%;">
                                                <tr>
                                               <!-- <td>Create Another <asp:CheckBox ID="CheckBox2" runat="server" class="btn mb-1 btn-primary"> </asp:CheckBox> &nbsp; </td>-->
                                                <td> <asp:Button ID="BtnCreate" runat="server" class="btn mb-1 btn-primary" Text="Create" OnClick="BtnCreate_Click"> </asp:Button> &nbsp; </td>
                                                <td> <asp:Button ID="BtnCancle" runat="server" class="btn mb-1 btn-primary" Text="Cancel"> </asp:Button> </td>
                                                </tr>
                                                </table>
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
    </asp:content>