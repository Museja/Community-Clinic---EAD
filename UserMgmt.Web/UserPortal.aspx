<%@ Page Title="User Portal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserPortal.aspx.cs" Inherits="UserMgmt.Web.UserPortal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>New User Registration</h2>

    <%-- Name --%>
    <div>
        <asp:Label runat="server" Text="First Name *" />
        <asp:TextBox ID="txtFirstName" runat="server" />
        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server"
            ControlToValidate="txtFirstName"
            ErrorMessage="First Name is required."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <div>
        <asp:Label runat="server" Text="Last Name *" />
        <asp:TextBox ID="txtLastName" runat="server" />
        <asp:RequiredFieldValidator ID="rfvLastName" runat="server"
            ControlToValidate="txtLastName"
            ErrorMessage="Last Name is required."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <%-- Email --%>
    <div>
        <asp:Label runat="server" Text="Email *" />
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
            ControlToValidate="txtEmail"
            ErrorMessage="Email is required."
            ForeColor="Red" Display="Dynamic" />
        <asp:RegularExpressionValidator ID="revEmail" runat="server"
            ControlToValidate="txtEmail"
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ErrorMessage="Enter a valid email address."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <%-- Date of Birth --%>
    <div>
        <asp:Label runat="server" Text="Date of Birth *" />
        <asp:TextBox ID="txtDob" runat="server" TextMode="Date" />
        <asp:RequiredFieldValidator ID="rfvDob" runat="server"
            ControlToValidate="txtDob"
            ErrorMessage="Date of Birth is required."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <%-- Gender --%>
    <div>
        <asp:Label runat="server" Text="Gender *" />
        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Text="Male" Value="Male" />
            <asp:ListItem Text="Female" Value="Female" />
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="rfvGender" runat="server"
            ControlToValidate="rblGender"
            ErrorMessage="Please select a gender."
            ForeColor="Red" Display="Dynamic"
            InitialValue="" />
    </div>

    <%-- Phone --%>
    <div>
        <asp:Label runat="server" Text="Cell Phone" />
        <asp:TextBox ID="txtCell" runat="server" placeholder="e.g. 8761234567" MaxLength="10" />
        <asp:RegularExpressionValidator ID="revCell" runat="server"
            ControlToValidate="txtCell"
            ValidationExpression="^\d{10}$"
            ErrorMessage="Cell number must be exactly 10 digits."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <div>
        <asp:Label runat="server" Text="Mobile Phone" />
        <asp:TextBox ID="txtMobile" runat="server" placeholder="e.g. 8761234567" MaxLength="10" />
        <asp:RegularExpressionValidator ID="revMobile" runat="server"
            ControlToValidate="txtMobile"
            ValidationExpression="^\d{10}$"
            ErrorMessage="Mobile number must be exactly 10 digits."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <%-- Address --%>
    <div>
        <asp:Label runat="server" Text="Address *" />
        <asp:TextBox ID="txtAddress" runat="server" />
        <asp:RequiredFieldValidator ID="rfvAddress" runat="server"
            ControlToValidate="txtAddress"
            ErrorMessage="Address is required."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <div>
        <asp:Label runat="server" Text="Town *" />
        <asp:TextBox ID="txtTown" runat="server" />
        <asp:RequiredFieldValidator ID="rfvTown" runat="server"
            ControlToValidate="txtTown"
            ErrorMessage="Town is required."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <%-- Parish --%>
    <div>
        <asp:Label runat="server" Text="Parish *" />
        <asp:DropDownList ID="ddlParish" runat="server">
            <asp:ListItem Text="Select a Parish" Value="" />
            <asp:ListItem Text="Clarendon" Value="Clarendon" />
            <asp:ListItem Text="Hanover" Value="Hanover" />
            <asp:ListItem Text="Kingston" Value="Kingston" />
            <asp:ListItem Text="Manchester" Value="Manchester" />
            <asp:ListItem Text="Portland" Value="Portland" />
            <asp:ListItem Text="Saint Andrew" Value="Saint Andrew" />
            <asp:ListItem Text="Saint Ann" Value="Saint Ann" />
            <asp:ListItem Text="Saint Catherine" Value="Saint Catherine" />
            <asp:ListItem Text="Saint Elizabeth" Value="Saint Elizabeth" />
            <asp:ListItem Text="Saint James" Value="Saint James" />
            <asp:ListItem Text="Saint Mary" Value="Saint Mary" />
            <asp:ListItem Text="Saint Thomas" Value="Saint Thomas" />
            <asp:ListItem Text="Trelawny" Value="Trelawny" />
            <asp:ListItem Text="Westmoreland" Value="Westmoreland" />
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvParish" runat="server"
            ControlToValidate="ddlParish"
            InitialValue=""
            ErrorMessage="Please select a parish."
            ForeColor="Red" Display="Dynamic" />
    </div>

    <%-- Buttons --%>
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Create User" OnClick="btnSave_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CausesValidation="false" />
    </div>

    <%-- Feedback --%>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />

</asp:Content>