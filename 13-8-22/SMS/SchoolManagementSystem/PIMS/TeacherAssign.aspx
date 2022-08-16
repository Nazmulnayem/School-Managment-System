<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMaster.Master" AutoEventWireup="true" CodeBehind="TeacherAssign.aspx.cs" Inherits="SchoolManagementSystem.PIMS.TeacherAssign" %>

<%@ Register Src="~/ResponseMessage.ascx" TagPrefix="uc1" TagName="ResponseMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField id="hdnStuId" runat="server"></asp:HiddenField>
    <uc1:ResponseMessage runat="server" ID="rmmsg" />
    <div class="content-wrapper">
    <div class="container">
        <div class="card card-primary">
            <h3 class="text-center">Class Shedule</h3>
            <uc1:ResponseMessage runat="server" ID="ResponseMessage" />
             <div class="card-body">
            <div class="row">
                 <div class="col-md-3">
                    <label class="form-label">Teacher</label>
                    <asp:DropDownList ID="ddlteacher" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <label class="form-label">Shift</label>
                    <asp:DropDownList ID="ddlShift" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlShift_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                 <div class="col-md-3">
                    <label class="form-label">Class Name</label>
                    <asp:DropDownList ID="ddlClass" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                 <div class="col-md-3">
                    <label class="form-label">Shedule Name</label>
                    <asp:DropDownList ID="ddlShedule" runat="server" CssClass="form-control" >
                    </asp:DropDownList>
                </div>
                 
               
                <div class="col-md-2 mt-1">
                    <label>&nbsp;</label>
                    <asp:Button ID="AddBtn" CssClass="btn btn-primary form-control" runat="server" Text="Add"   />
                </div>
                <div class="col-md-12 mt-1">
                    <label>Class Shedule</label>
                    <asp:GridView ID="gvClassShedule" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Shift" HeaderText="Shift" />
                            <asp:BoundField DataField="ShiftId" HeaderText="ShiftId" Visible="false" />
                            <asp:BoundField DataField="Class" HeaderText="Class" />
                            <asp:BoundField DataField="ClassID" HeaderText="ClassID"  Visible="false" />
                            <asp:BoundField DataField="WeekDay" HeaderText="WeekDay" />
                            <asp:BoundField DataField="Subject" HeaderText="Subject" />
                           <asp:BoundField DataField="SubjectId" HeaderText="SubjectId" Visible="false" />
                            <asp:BoundField DataField="StartTime" HeaderText="StartTime" />
                            <asp:BoundField DataField="EndTime" HeaderText="EndTime" />
                          </Columns>
                    </asp:GridView>
                </div>
                 <div class="col-md-2 mt-1">
                    <label>&nbsp;</label>
                    <asp:Button ID="btnSave" CssClass="btn btn-primary form-control" runat="server" Text="Submit"  />
                </div>

            </div>
        </div>
        </div>
        </div>
    </div>
</asp:Content>
