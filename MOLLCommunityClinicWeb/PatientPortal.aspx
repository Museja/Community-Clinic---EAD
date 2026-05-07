<%@ Page Title="Patient Portal"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="PatientPortal.aspx.cs"
Inherits="MOLLCommunityClinicWeb.PatientPortal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
    body {
        background-color: #f4f8fc;
    }

    .portal-wrapper {
        max-width: 1100px;
        margin: 40px auto;
    }

    .portal-title {
        text-align: center;
        font-weight: 700;
        color: #0d6efd;
        margin-bottom: 30px;
    }

    .section-card {
        background: white;
        border-radius: 16px;
        padding: 25px;
        box-shadow: 0 8px 20px rgba(0,0,0,0.06);
        margin-bottom: 25px;
        border-top: 5px solid #0d6efd;
    }

    .section-title {
        font-weight: 700;
        color: #0d6efd;
        margin-bottom: 20px;
    }

    .form-control {
        border-radius: 10px !important;
        padding: 10px;
    }

    .btn {
        border-radius: 10px !important;
        font-weight: 600;
    }

    .grid table {
        border-radius: 12px;
        overflow: hidden;
    }

    .btn-group-custom {
        display: flex;
        flex-wrap: wrap;
        gap: 10px;
    }

    .message-label {
        display: block;
        text-align: center;
        font-weight: 600;
        margin-bottom: 15px;
    }
</style>

<div class="portal-wrapper">

    <h2 class="portal-title">Patient Portal</h2>

    <!-- PROFILE -->
    <div class="section-card">

        <h4 class="section-title">Profile Information</h4>

        <div class="row g-3">

            <div class="col-md-6">
                <label>Full Name</label>
                <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Phone</label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Email</label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Date of Birth</label>
                <asp:TextBox ID="dtDOB" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-12">
                <label>Address</label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <br />

        <asp:Button ID="btnUpdateProfile"
            runat="server"
            Text="Update Profile"
            CssClass="btn btn-primary"
            OnClick="btnUpdateProfile_Click" />

    </div>

    <!-- APPOINTMENTS -->
    <div class="section-card">

        <h4 class="section-title">Appointments</h4>

        <div class="btn-group-custom mb-3">

            <asp:Button ID="btnRefreshAppointments"
                runat="server"
                Text="Load Appointments"
                CssClass="btn btn-info text-white"
                OnClick="btnRefreshAppointments_Click" />

            <asp:Button ID="btnBookAppointment"
                runat="server"
                Text="Book Appointment"
                CssClass="btn btn-success"
                OnClick="btnBookAppointment_Click" />

        </div>

        <asp:GridView ID="gvAppointments"
            runat="server"
            CssClass="table table-striped table-hover grid"
            AutoGenerateColumns="true">
        </asp:GridView>

    </div>

    <!-- MEDICAL HISTORY -->
    <div class="section-card">

        <h4 class="section-title">Medical History</h4>

        <asp:Button ID="btnLoadHistory"
            runat="server"
            Text="Load History"
            CssClass="btn btn-warning mb-3"
            OnClick="btnLoadHistory_Click" />

        <asp:GridView ID="gvHistory"
            runat="server"
            CssClass="table table-striped table-hover grid"
            AutoGenerateColumns="true">
        </asp:GridView>

    </div>

    <!-- PRESCRIPTIONS -->
    <div class="section-card">

        <h4 class="section-title">Prescriptions</h4>

        <asp:Button ID="btnLoadPrescriptions"
            runat="server"
            Text="Load Prescriptions"
            CssClass="btn btn-secondary mb-3"
            OnClick="btnLoadPrescriptions_Click" />

        <asp:GridView ID="gvPrescriptions"
            runat="server"
            CssClass="table table-striped table-hover grid"
            AutoGenerateColumns="true">
        </asp:GridView>

    </div>

    <!-- NAVIGATION -->
    <div class="section-card text-center">

        <asp:Button ID="btnBack"
            runat="server"
            Text="Back"
            CssClass="btn btn-dark me-2"
            OnClick="btnBack_Click" />

        <asp:Button ID="btnLogout"
            runat="server"
            Text="Logout"
            CssClass="btn btn-danger"
            OnClick="btnLogout_Click" />

    </div>

</div>

</asp:Content>