<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEvent.aspx.cs" Inherits="Event.EditEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Label ID="EventNameLabel" runat="server" Text="Event Name:"></asp:Label>
        <asp:TextBox ID="EventName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="EventDateLabel" runat="server" Text="Event Date:"></asp:Label>
        <asp:TextBox ID="EventDate" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="Save_Click" />
        <asp:Label ID="ConfirmationLabel" runat="server"></asp:Label>
</asp:Content>

