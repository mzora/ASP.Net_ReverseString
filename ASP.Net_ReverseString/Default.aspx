<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.Net_ReverseString.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-8">
            <div class="row justify-content-center" style="margin-top:20vh">
                <div class="form-group d-inline">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Text to Reverse"></asp:TextBox>
                </div>
                <div class="d-inline" style="margin-left:10px">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-info" />
                </div>
            </div>

            <div class="form-group">
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered"></asp:GridView>
            </div>
        </div>
    </form>

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</body>
</html>
