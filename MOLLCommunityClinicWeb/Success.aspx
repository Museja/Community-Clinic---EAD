<%@ Page Title="Registration"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="Registration.aspx.cs"
Inherits="MOLLCommunityClinicWeb.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
    .success-wrapper {
        min-height: 80vh;
        display: flex;
        justify-content: center;
        align-items: center;
        background: linear-gradient(to bottom right, #eef5ff, #dbeafe);
        padding: 20px;
    }

    .success-card {
        background: white;
        padding: 50px;
        border-radius: 20px;
        box-shadow: 0 10px 30px rgba(0,0,0,0.12);
        text-align: center;
        max-width: 500px;
        width: 100%;
        border-top: 8px solid #0d6efd;
    }

    .success-icon {
        font-size: 70px;
        color: #0d6efd;
        margin-bottom: 20px;
    }

    .success-title {
        color: #0d6efd;
        font-weight: 700;
        margin-bottom: 15px;
    }

    .success-text {
        color: #4b5563;
        font-size: 18px;
        margin-bottom: 35px;
    }

    .btn-custom {
        padding: 12px 35px;
        border-radius: 12px;
        font-size: 16px;
        font-weight: 600;
        min-width: 140px;
    }

    .button-group {
        display: flex;
        justify-content: center;
        gap: 15px;
        flex-wrap: wrap;
    }
</style>

<div class="success-wrapper">

    <div class="success-card">

        <div class="success-icon">
            ✔
        </div>

        <h1 class="success-title">
            Registration Successful!
        </h1>

        <p class="success-text">
            Your account has been created successfully.
        </p>

        <div class="button-group">

            <asp:Button ID="btnNext"
                runat="server"
                Text="Continue"
                CssClass="btn btn-primary btn-custom"
                OnClick="btnNext_Click" />

            <asp:Button ID="btnExit"
                runat="server"
                Text="Exit"
                CssClass="btn btn-dark btn-custom"
                OnClick="btnExit_Click" />

        </div>

    </div>

</div>

</asp:Content>