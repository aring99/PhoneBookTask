<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewContact.aspx.cs" Inherits="PhoneBookTask.NewContact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

<!-- Latest compiled and minified JavaScript -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">
            <asp:LinkButton runat="server" CssClass="btn btn-default" ID="btnHomePage" Text="Home Page" OnClick="btnHomePage_Click" />
                </div>
            <div class="row">
            <asp:Label runat="server" Text="Name"/>
            <asp:TextBox runat="server" ID="name"/>
            </div>
            <div class="row">
            <asp:Label runat="server" Text="Surname"/>
            <asp:TextBox runat="server" ID="surname"/>
            </div>
            <div class="row">
            <asp:Label runat="server" Text="Phone"/>
            <asp:TextBox runat="server" ID="phone"/>
            </div>
                <asp:LinkButton runat="server" CssClass="btn btn-success" Text="Save" ID="btnSave" OnClick="btnSave_Click" />
                </div>
        </div>
    </form>
</body>
</html>
