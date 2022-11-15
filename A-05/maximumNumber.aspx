<!-- FILE          : maximumNumber -->
<!-- PROJECT       : Assignment 5 -->
<!-- PROGRAMMERS   : Kyle Dunn, David Czachor -->
<!-- FIRST VERSION : 2022-11-15 -->
<!-- PURPOSE       : This page validates user input for the maximum number -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="maximumNumber.aspx.cs" Inherits="A_05._maximumNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hi-Lo Game</title>
    <link rel="stylesheet" href="styles.css"/>
</head>
<body>
    <form id="MaximumNumberForm" runat="server">
        <div class="game">
            <asp:Label ID="maxNumberLbl" runat="server" AssociatedControlID="maxNumber" />
            <asp:TextBox ID="maxNumber" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="maxNumberRequiredValidator" runat="server"
                Display="Dynamic" CssClass="error"
                ControlToValidate="maxNumber" 
                ErrorMessage="This field is required. Please enter something, ANYTHING plz" />
            <asp:RangeValidator ID="maxNumberRangeValidator" runat="server"
                Display="Dynamic" CssClass="error"
                ControlToValidate="maxNumber"
                Type="Integer"
                MinimumValue="1"
                MaximumValue="1000000"
                ErrorMessage="This field is out of range. Please enter a range between 1 and 1,000,000." />
            <asp:Button ID="submitBtn" runat="server" CausesValidation="true" Text="Submit" OnClick="submitBtn_Click"/>
        </div>
    </form>
</body>
</html>
