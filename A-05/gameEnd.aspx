<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gameEnd.aspx.cs" Inherits="A_05.gameEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hi-Lo Game</title>
    <link rel="stylesheet" href="styles.css"/>
</head>
<body id="winnerBody" runat="server">
    <form id="EndGameForm" runat="server">
        <asp:Image ID="starImg" runat="server" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/6/63/Star%2A.svg" />
        <div class="game">
            <asp:Label ID="winner" runat="server">You are a WINNER!</asp:Label>
            <asp:Button ID="submitBtn" runat="server" Text="Play Again" OnClick="submitBtn_Click" />
        </div>
    </form>
</body>
</html>
