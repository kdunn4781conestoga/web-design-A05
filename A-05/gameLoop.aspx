﻿<!-- FILE          : gameLoop.aspx -->
<!-- PROJECT       : Assignment 5 -->
<!-- PROGRAMMERS   : Kyle Dunn, David Czachor -->
<!-- FIRST VERSION : 2022-11-15 -->
<!-- PURPOSE       : This page performs the game loop of prompting the user to guess and number. They will guess until they win -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gameLoop.aspx.cs" Inherits="A_05.gameLoop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hi-Lo Game</title>
    <link rel="stylesheet" href="styles.css"/>
</head>
<body>
    <form id="NumberGuessForm" runat="server" autocomplete="off">
        <div class="game">
            <asp:Label ID="guessLbl" runat="server" AssociatedControlID="userGuess" />
            <asp:TextBox ID="userGuess" runat="server" placeholder ="hi"/>
            <asp:RequiredFieldValidator ID="userGuessRequiredValidator" runat="server"
                Display="Dynamic" CssClass="error"
                ControlToValidate="userGuess" 
                ErrorMessage="This field is required. Please enter something, ANYTHING plz" />
            <asp:RangeValidator ID="userGuessRangeValidator" runat="server"
                Display="Dynamic" CssClass="error"
                ControlToValidate="userGuess"
                Type="Integer" />
            <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click"/>
        </div>
    </form>
</body>
</html>
