<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="Event.AddEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Event</h2>
    <asp:TextBox ID="EventName" runat="server"></asp:TextBox>
    <asp:Calendar ID="EventDate" runat="server"></asp:Calendar>
    <asp:Button ID="AddEventButton" runat="server" Text="Add Event" OnClick="AddEvent_Click" />
    <asp:Label ID="ConfirmationLabel" runat="server"></asp:Label>
</asp:Content>
