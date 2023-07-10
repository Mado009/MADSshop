<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="MADSshop.Views.Admin.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"><h3 class="text-center">Manage Books</h3></div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Books Title</label>
                <input type="text" name="username" placeholder="Title" class="form-control" runat="server" id="BtitleTb" />
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Books Author</label>
                <asp:DropDownList runat="server" class="form-control" id="BauthTd" ></asp:DropDownList>
                
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50" >Categories</label>
                
                <asp:DropDownList runat="server" class="form-control" id="BcatTd" ></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Price</label>
                <input type="text" name="username" placeholder="Price" class="form-control" runat="server" id="BpriceTb"  />
            </div>
            <div class="mb-3">
                <label for="username" class="form-label text-success text-black-50">Quantity</label>
                <input type="text" name="username" placeholder="Quantity" class="form-control" runat="server" id="Bquantity"  />
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
        <div class="col-md-8 mt-2">
            <asp:GridView ID="BooksList" runat="server" class="table" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged"></asp:GridView>

        </div>
    </div>
</asp:Content>
