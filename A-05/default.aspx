<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="A_05._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hi-Lo Game</title>
    <link rel="stylesheet" href="styles.css"/>
</head>
<body>
    <form id="PlayerNameForm" runat="server">
        <div class="game">
            Please enter your name:
            <asp:TextBox ID="playerName" runat="server"></asp:TextBox>
            <asp:Button ID="submit" runat="server" CausesValidation="true" Text="Submit" />
        </div>
    </form>
</body>
</html>
