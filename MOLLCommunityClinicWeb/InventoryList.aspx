<%@ Page Title="Inventory List"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="InventoryList.aspx.cs"
Inherits="MOLLCommunityClinicWeb.InventoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<style>
    body {
        background-color: #f4f8fc;
    }

    .inventory-wrapper {
        max-width: 1100px;
        margin: 40px auto;
    }

    .inventory-card {
        background: white;
        padding: 30px;
        border-radius: 16px;
        box-shadow: 0 6px 20px rgba(0,0,0,0.08);
        border-top: 6px solid #0d6efd;
    }

    .page-title {
        text-align: center;
        color: #0d6efd;
        font-weight: 700;
        margin-bottom: 20px;
    }

    .table-style {
        width: 100%;
    }

    .table-style th {
        background-color: #0d6efd;
        color: white;
        padding: 10px;
    }

    .table-style td {
        padding: 10px;
    }

    .table-style tr:nth-child(even) {
        background-color: #f2f6ff;
    }
</style>

<div class="container inventory-wrapper">

    <div class="inventory-card">

        <h2 class="page-title">Inventory List</h2>

        <asp:GridView ID="gvInventory"
            runat="server"
            CssClass="table-style"
            AutoGenerateColumns="True">
        </asp:GridView>

    </div>

</div>

</asp:Content>