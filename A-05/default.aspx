<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="A_05._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hi-Lo Game</title>
</head>
<body bgcolor="darkred">
    <form id="PlayerNameForm" runat="server">
        <div>
            Please enter your name:
            <asp:TextBox ID="playerName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="playerNameValidator" runat="server"
                ControlToValidate="playerName" ErrorMessage="Please enter a value"/>
        </div>
    </form>
</body>
</html>
