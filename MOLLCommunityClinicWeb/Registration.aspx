<%@ Page Title="Registration"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="Registration.aspx.cs"
Inherits="MOLLCommunityClinicWeb.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
   
    body {
        background-color: #f4f8fc;
    }

    .register-wrapper {
        max-width: 700px;
        margin: 50px auto;
        padding: 20px;
    }

    .register-card {
        background: white;
        padding: 40px;
        border-radius: 20px;
        box-shadow: 0 10px 25px rgba(0,0,0,0.08);
        border-top: 8px solid #0d6efd;
    }

    .register-title {
        text-align: center;
        color: #0d6efd;
        font-weight: 700;
        margin-bottom: 30px;
    }

    .form-label {
        font-weight: 600;
        color: #1f2937;
        margin-bottom: 8px;
    }

    .form-control {
        border-radius: 10px !important;
        padding: 12px;
        border: 1px solid #d1d5db;
    }

    .form-control:focus {
        border-color: #0d6efd;
        box-shadow: 0 0 0 0.2rem rgba(13,110,253,.15);
    }

    .role-section {
        background: #eef5ff;
        padding: 20px;
        border-radius: 12px;
        margin-top: 10px;
    }

    .role-section input {
        margin-right: 8px;
    }

    .role-section label {
        margin-right: 20px;
        font-weight: 500;
    }

    .panel-box {
        background: #f8fafc;
        padding: 15px;
        border-radius: 12px;
        border: 1px solid #e5e7eb;
    }

    .btn-register {
        width: 100%;
        padding: 14px;
        border-radius: 12px;
        font-size: 16px;
        font-weight: 600;
        margin-top: 10px;
    }

    .message-label {
        display: block;
        text-align: center;
        margin-bottom: 20px;
        font-weight: 600;
    }
</style>

<div class="container register-wrapper">

    <div class="register-card">

        <h2 class="register-title">Create Your Account</h2>

        <div class="mb-4">
            <label class="form-label">Full Name</label>
            <asp:TextBox ID="txtFullname"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-4">
            <label class="form-label">Email</label>
            <asp:TextBox ID="txtEmail"
                runat="server"
                TextMode="Email"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-4">
            <label class="form-label">Password</label>
            <asp:TextBox ID="txtPassword"
                runat="server"
                TextMode="Password"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="mb-4">
            <label class="form-label">Confirm Password</label>
            <asp:TextBox ID="txtConfirmpassword"
                runat="server"
                TextMode="Password"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <div class="role-section">

            <div class="mb-2 fw-bold text-primary">
                Select Role
            </div>

            <asp:RadioButton ID="radioPatient"
                runat="server"
                GroupName="Role"
                Text="Patient"
                AutoPostBack="true"
                OnCheckedChanged="Role_CheckedChanged" />

            <asp:RadioButton ID="radioAdmin"
                runat="server"
                GroupName="Role"
                Text="Admin"
                AutoPostBack="true"
                OnCheckedChanged="Role_CheckedChanged" />

            <asp:RadioButton ID="radioMedicalstaff"
                runat="server"
                GroupName="Role"
                Text="Medical Staff"
                AutoPostBack="true"
                OnCheckedChanged="Role_CheckedChanged" />

        </div>

        <br />

        <asp:Panel ID="pnlAdmin"
            runat="server"
            Visible="false"
            CssClass="panel-box">

            <label class="form-label">Admin ID</label>

            <asp:TextBox ID="txtAdminId"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>

        </asp:Panel>

        <br />

        <asp:Panel ID="pnlMedStaff"
            runat="server"
            Visible="false"
            CssClass="panel-box">

            <label class="form-label">Medical Staff ID</label>

            <asp:TextBox ID="txtMedStaff"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>

        </asp:Panel>

        <asp:Button ID="btnRegister"
            runat="server"
            Text="Register"
            CssClass="btn btn-primary btn-register"
            OnClick="btnRegister_Click" />

    </div>

</div>

</asp:Content>