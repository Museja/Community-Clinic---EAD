<%@ Page Title="Patient List"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="Patientdata.aspx.cs"
Inherits="MOLLCommunityClinicWeb.Patientdata" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
    body {
        background-color: #f4f8fc;
    }

    .patient-wrapper {
        max-width: 1100px;
        margin: 40px auto;
    }

    .page-title {
        text-align: center;
        font-weight: 800;
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

    .form-control:focus {
        border-color: #0d6efd;
        box-shadow: 0 0 0 0.2rem rgba(13,110,253,.15);
    }

    .btn {
        border-radius: 10px !important;
        font-weight: 600;
        min-width: 120px;
    }

    .btn-group-custom {
        display: flex;
        gap: 10px;
        flex-wrap: wrap;
        justify-content: center;
        margin-top: 20px;
    }

    .message-label {
        display: block;
        text-align: center;
        font-weight: 600;
        margin-bottom: 20px;
    }
</style>

<div class="patient-wrapper">

    <h2 class="page-title">Patient Information</h2>

    <!-- PERSONAL INFO -->
    <div class="section-card">

        <h4 class="section-title">Personal Information</h4>

        <div class="row g-3">

            <div class="col-md-6">
                <label>Name</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Date of Birth</label>
                <asp:TextBox ID="txtDOB" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Age</label>
                <asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Gender</label>
                <asp:TextBox ID="txtGender" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Phone Number</label>
                <asp:TextBox ID="txtPhonenumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-6">
                <label>Email</label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="col-md-12">
                <label>Address</label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

    </div>

    <!-- MEDICAL INFO -->
    <div class="section-card">

        <h4 class="section-title">Medical Information</h4>

        <div class="mb-3">
            <label>Allergies</label>
            <asp:TextBox ID="txtAllergies"
                runat="server"
                TextMode="MultiLine"
                Rows="3"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-3">
            <label>Medical History</label>
            <asp:TextBox ID="txtHistory"
                runat="server"
                TextMode="MultiLine"
                Rows="3"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-3">
            <label>Medications</label>
            <asp:TextBox ID="txtMedications"
                runat="server"
                TextMode="MultiLine"
                Rows="3"
                CssClass="form-control">
            </asp:TextBox>
        </div>

    </div>

    <!-- BUTTONS -->
    <div class="section-card text-center">

        <asp:Button ID="btnSave"
            runat="server"
            Text="Save"
            CssClass="btn btn-primary"
            OnClick="btnSave_Click" />

        <asp:Button ID="btnUpdate"
            runat="server"
            Text="Update"
            CssClass="btn btn-warning text-white"
            OnClick="btnUpdate_Click" />

        <asp:Button ID="btnClear"
            runat="server"
            Text="Clear"
            CssClass="btn btn-secondary"
            OnClick="btnClear_Click" />

        <asp:Button ID="btnBack"
            runat="server"
            Text="Back"
            CssClass="btn btn-dark"
            OnClick="btnBack_Click" />

    </div>

</div>

</asp:Content>