<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Seller.aspx.cs" Inherits="MADSshop.Views.Admin.Seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"><h3 class="text-center">Manage Sellers</h3></div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Seller Name</label>
                <input type="text" name="username" placeholder="Name" class="form-control" runat="server" id="SNameTb" />
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Seller Email</label>
                <input type="email" name="username" placeholder="Email" class="form-control" runat="server" id="EmailTb" />
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Seller Phone</label>
                <input type="text" name="username" placeholder="Phone Number" class="form-control" runat="server" id="PhoneTb" />
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Seller Address</label>
                <input type="text" name="username" placeholder="Address" class="form-control" runat="server" id="AddressTb" />
            </div>


            <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
            <div class="row">
                <div class="col d-grid">
                    <asp:Button runat="server" ID="EditBtn" Text="Update" class="btn-success btn-block btn" OnClick="EditBtn_Click" /></div>
                <div class="col d-grid">
                    <asp:Button runat="server" ID="SaveBtn" Text="Save" class="btn-success btn-block btn" OnClick="SaveBtn_Click" /></div>
                <div class="col d-grid">
                    <asp:Button runat="server" ID="DeleteBtn" Text="Delete" class="btn-danger btn-block btn" OnClick="DeleteBtn_Click" /></div>
            </div>
        </div>
        <div class="col-md-8">
            <asp:GridView ID="SellerList" runat="server" class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged"></asp:GridView>

        </div>
    </div>
</asp:Content>
