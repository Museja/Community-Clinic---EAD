<%@ Page Title="Registration"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="Registration.aspx.cs"
Inherits="MOLLCommunityClinicWeb1.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registration</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

    <br /><br />

    Full Name:
    <asp:TextBox ID="txtFullname" runat="server" /><br /><br />

    Email:
    <asp:TextBox ID="txtEmail" runat="server" /><br /><br />

    Password:
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br /><br />

    Confirm Password:
    <asp:TextBox ID="txtConfirmpassword" runat="server" TextMode="Password" /><br /><br />

    <h4>Select Role</h4>

    <asp:RadioButton ID="radioPatient" runat="server" GroupName="Role" Text="Patient"
        AutoPostBack="true" OnCheckedChanged="Role_CheckedChanged" />

    <asp:RadioButton ID="radioAdmin" runat="server" GroupName="Role" Text="Admin"
        AutoPostBack="true" OnCheckedChanged="Role_CheckedChanged" />

    <asp:RadioButton ID="radioMedicalstaff" runat="server" GroupName="Role" Text="Medical Staff"
        AutoPostBack="true" OnCheckedChanged="Role_CheckedChanged" />

    <br /><br />

    <asp:Panel ID="pnlAdmin" runat="server" Visible="false">
        Admin ID:
        <asp:TextBox ID="txtAdminId" runat="server" />
    </asp:Panel>

    <br />

    <asp:Panel ID="pnlMedStaff" runat="server" Visible="false">
        Staff ID:
        <asp:TextBox ID="txtMedStaff" runat="server" />
    </asp:Panel>

    <br />

    <asp:Button ID="btnRegister" runat="server"
        Text="Register"
        OnClick="btnRegister_Click" />

</asp:Content>