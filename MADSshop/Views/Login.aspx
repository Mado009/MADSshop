<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MADSshop.Assets.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Lib/css/bootstrap.css" />

</head>
<body>
    <div class="container-fluid">
        <div class="row mt-3 mb-5">

        </div>
        <div class="row">
            
             <div class="col  ">
             </div>
             <div class="col-ml-5">
                 <form id="form1" runat="server">
                     <div >
                         <div >
                             <img src="../Assets/Images/book.jpg" />
                         </div>
                         <div class="mx-auto">
                             <label for="username" class="form-label">Email</label>
                             <input type="email" name="username" placeholder="Email" class="form-control" runat="server" id="UsernameTb" />
                         </div>

                         <div class="mt-3 ">
                             <label for="password" class="form-label">Password</label>
                             <input type="password" name="password" placeholder="Password" class="form-control" runat="server" id="PasswordTb" />
                         </div>

                         <div class="mt-3 d-grid ">
                             <asp:Button runat="server" Text="Login" class="btn-success" ID="LoginBtn" OnClick="LoginBtn_Click" />
                         </div>
                     </div>
                </form>
            </div>
            <div class="col">

            </div>
        </div>                   
   </div>
    
</body>
</html>
