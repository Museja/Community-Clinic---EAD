<%@ Page Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="PatientPortal.aspx.cs"
Inherits="MOLLCommunityClinicWeb1.PatientPortal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h2>Patient Portal</h2>

<asp:Label ID="MOLL" runat="server" ForeColor="Green"></asp:Label>

<hr />

<!-- ================= PROFILE ================= -->
<h3>Profile</h3>

Full Name:
<asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" /><br />

Email:
<asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" /><br />

Phone:
<asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" /><br />

Address:
<asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="2" CssClass="form-control" /><br />

Date of Birth:
<asp:TextBox ID="txtDOB" runat="server" TextMode="Date" CssClass="form-control" /><br />

<hr />

<!-- ================= APPOINTMENTS ================= -->
<h3>Appointments</h3>

<asp:GridView ID="gvAppointments" runat="server" CssClass="table table-bordered"></asp:GridView>

<br />

Appointment ID:
<asp:TextBox ID="txtAppointmentId" runat="server" CssClass="form-control" /><br />

New Date:
<asp:TextBox ID="txtNewDate" runat="server" TextMode="Date" CssClass="form-control" /><br />

<asp:Button ID="btnReschedule" runat="server"
    Text="Reschedule"
    CssClass="btn btn-warning"
    OnClick="btnReschedule_Click" />

<asp:Button ID="btnCancelAppointment" runat="server"
    Text="Cancel Appointment"
    CssClass="btn btn-danger"
    OnClick="btnCancelAppointment_Click" />

<hr />

<!-- ================= MEDICAL HISTORY ================= -->
<h3>Medical History</h3>

<asp:GridView ID="gvHistory" runat="server" CssClass="table table-bordered"></asp:GridView>

<hr />

<!-- ================= PRESCRIPTIONS ================= -->
<h3>Prescriptions</h3>

<asp:GridView ID="gvPrescriptions" runat="server" CssClass="table table-bordered"></asp:GridView>

<hr />

<!-- ================= ACTION BUTTONS ================= -->

<asp:Button ID="btnSave" runat="server"
    Text="Save Profile"
    CssClass="btn btn-primary"
    OnClick="btnSave_Click" />

<asp:Button ID="btnLoad" runat="server"
    Text="Load Data"
    CssClass="btn btn-info"
    OnClick="btnLoad_Click"
    Style="margin-left:10px;" />

<asp:Button ID="btnBack" runat="server"
    Text="Back"
    CssClass="btn btn-secondary"
    OnClick="btnBack_Click"
    Style="margin-left:10px;" />

<asp:Button ID="btnExit" runat="server"
    Text="Exit"
    CssClass="btn btn-danger"
    OnClick="btnExit_Click"
    Style="margin-left:10px;" />

</asp:Content>
