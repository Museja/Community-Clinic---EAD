<%@ Page Title="Inventory Item"
Language="C#"
MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="Inventory.aspx.cs"
Inherits="MOLLCommunityClinicWeb.InventoryItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:Label ID="lblMessage" runat="server" CssClass="fw-bold d-block mb-3"></asp:Label>

<style>
    .inventory-wrapper {
        max-width: 1000px;
        margin: 40px auto;
    }

    .inventory-card {
        background: white;
        padding: 35px;
        border-radius: 16px;
        box-shadow: 0 6px 20px rgba(0,0,0,0.08);
        border-top: 6px solid #0d6efd;
    }

    .page-title {
        color: #0d6efd;
        font-weight: 700;
        margin-bottom: 30px;
        text-align: center;
    }

    .form-label {
        font-weight: 600;
        margin-bottom: 6px;
    }

    .form-control {
        border-radius: 10px !important;
    }

    body {
        background-color: #f4f8fc;
    }
</style>

<div class="container inventory-wrapper">

    <div class="inventory-card">

        <h2 class="page-title">Inventory Management</h2>

        <div class="row g-3">

            <div class="col-md-6">
                <label class="form-label">Item Name</label>
                <asp:TextBox ID="txtItem" runat="server" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Date Added</label>
                <asp:TextBox ID="txtDateAdded" runat="server" TextMode="Date" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Quantity</label>
                <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Price</label>
                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" />
            </div>

            <div class="col-12">
                <label class="form-label">Description</label>
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Expiration Date</label>
                <asp:TextBox ID="txtExpiration" runat="server" TextMode="Date" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Category</label>
                <asp:TextBox ID="txtCategory" runat="server" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Unit</label>
                <asp:TextBox ID="txtUnit" runat="server" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Batch Number</label>
                <asp:TextBox ID="txtBatchNumber" runat="server" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Manufacturer</label>
                <asp:TextBox ID="txtManufacturer" runat="server" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Supplier</label>
                <asp:TextBox ID="txtSupplier" runat="server" CssClass="form-control" />
            </div>

            <div class="col-md-6">
                <label class="form-label">Status</label>
                <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control" />
            </div>

            <div class="col-12">
                <label class="form-label">Notes</label>
                <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" />
            </div>

        </div>

        <div class="text-center mt-4">

            <asp:Button ID="btnSave" runat="server" Text="Save"
                CssClass="btn btn-primary me-2"
                OnClick="btnSave_Click" />

            <asp:Button ID="btnUpdate" runat="server" Text="Update"
                CssClass="btn btn-info text-white me-2"
                OnClick="btnUpdate_Click" />

            <asp:Button ID="btnClear" runat="server" Text="Clear"
                CssClass="btn btn-secondary me-2"
                OnClick="btnClear_Click" />

            <asp:Button ID="btnBack" runat="server" Text="Back"
                CssClass="btn btn-dark"
                OnClick="btnBack_Click" />

        </div>

    </div>

</div>

</asp:Content>