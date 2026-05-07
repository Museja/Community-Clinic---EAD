<%@ Page Title="Logout"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="Logout.aspx.cs"
Inherits="MOLLCommunityClinicWeb.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .logout-wrapper {
        max-width: 600px;
        margin: 80px auto;
    }

    .logout-card {
        background: white;
        border-radius: 18px;
        padding: 50px;
        text-align: center;
        box-shadow: 0 10px 25px rgba(0,0,0,0.08);
        border-top: 6px solid #0d6efd;
    }

    .logout-icon {
        font-size: 70px;
        color: #0d6efd;
        margin-bottom: 15px;
    }

    .logout-title {
        font-weight: 800;
        color: #0d6efd;
        margin-bottom: 10px;
    }

    .logout-text {
        color: #6c757d;
        font-size: 16px;
        margin-bottom: 30px;
    }

    .btn-login {
        background-color: #0d6efd;
        color: white;
        padding: 12px 30px;
        border-radius: 12px;
        font-weight: 600;
        text-decoration: none;
        display: inline-block;
        transition: 0.2s;
    }

    .btn-login:hover {
        background-color: #0b5ed7;
        color: white;
    }
</style>

<div class="logout-wrapper">

    <div class="logout-card">

        <div class="logout-icon">
            ✔
        </div>

        <h2 class="logout-title">
            You have been logged out
        </h2>

        <p class="logout-text">
            You have successfully signed out of the MOLL Community Clinic system.
        </p>

        <asp:HyperLink ID="lnkLogin"
            runat="server"
            NavigateUrl="~/Login.aspx"
            CssClass="btn-login"
            Text="Login Again">
        </asp:HyperLink>

    </div>

</div>

</asp:Content>