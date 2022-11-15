<!-- FILE          : default.aspx -->
<!-- PROJECT       : Assignment 5 -->
<!-- PROGRAMMERS   : Kyle Dunn, David Czachor -->
<!-- FIRST VERSION : 2022-11-15 -->
<!-- PURPOSE       :  This page validates user input for the player name -->

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
            <asp:Label ID="playerNameLbl" runat="server" AssociatedControlID="playerName">Enter your name</asp:Label>
            <asp:TextBox ID="playerName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="playerNameRequiredValidator" runat="server"
                Display="Dynamic" CssClass="error"
                ControlToValidate="playerName" ErrorMessage="This field is required. Please enter something, ANYTHING plz"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="playerNameValidator" runat="server"
                Display="Dynamic" CssClass="error"
                ControlToValidate="playerName" ErrorMessage="Invalid characters used in player name."
                OnServerValidate="playerNameCustomValidator_ServerValidate"></asp:CustomValidator>
            <asp:Button ID="submitBtn" runat="server" CausesValidation="true" Text="Submit" OnClick="submit_Click"/>
        </div>
        <br />
    </form>
</body>
</html>
