<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="MADSshop.Views.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"><h3 class="text-center">Manage Categories</h3></div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Category Name</label>
                <input type="text" name="username" placeholder="Title" class="form-control" runat="server" id="CatName"/>
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Category Description</label>
                <input type="text" name="username" placeholder="Title" class="form-control" runat="server" id="DescriptionTb"/>
            </div>
            <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
            <div class="row">
                <div class="col d-grid">
                    <asp:Button runat="server" ID="Editbtn" Text="Update" class="btn-success btn-block btn" OnClick="Editbtn_Click" /></div>
                <div class="col d-grid"><asp:Button runat="server" ID="Savebtn" Text="Save" class="btn-success btn-block btn" OnClick="Savebtn_Click" /></div>
                <div class="col d-grid">
                    <asp:Button runat="server" ID="Deletebtn" Text="Delete" class="btn-danger btn-block btn" OnClick="Deletebtn_Click" /></div>
            </div>
        </div>
        <div class="col-md-8">
            <asp:GridView ID="CategoryList" class="table" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged"></asp:GridView>

        </div>
    </div>
</asp:Content>
