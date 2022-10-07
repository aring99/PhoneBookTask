<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PhoneBookTask.HomePage" %>

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
            <asp:LinkButton runat="server" CssClass="btn btn-success" ID="addContact" Text="New Contact" OnClick="addContact_Click" />
        </div>
        <div>
            <asp:LinkButton runat="server" CssClass=" btn btn-danger " ID="logOut" Text="Log Out" OnClick="logOut_Click"  />
        </div>
        <div>
            <asp:LinkButton runat="server" CssClass=" btn btn-default " ID="showContacts" Text="Show Contacts" OnClick="showContacts_Click"  />
        </div>
        <div>
            <asp:LinkButton runat="server" CssClass=" btn btn-warning " ID="addUser" Text="Add Users" OnClick ="addUser_Click" Visible="false" />
        </div>
    </form> 
</body>
</html>
