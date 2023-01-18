<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="Event.AddEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Event</h2>
    <div class="form-group">
        <asp:Label ID="EventNameLabel" runat="server" Text="Event Name:" CssClass="control-label" AssociatedControlID="EventName"></asp:Label>
        <asp:TextBox ID="EventName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="EventDateLabel" runat="server" Text="Event Date:" CssClass="control-label" AssociatedControlID="EventDate"></asp:Label>
        <asp:TextBox ID="EventDate" runat="server" CssClass="form-control" TextMode="DateTimeLocal"></asp:TextBox>
<%--        <asp:Calendar ID="TextBox1" runat="server" Width="200px" CssClass="form" TextMode="Date"></asp:Calendar>--%>

    </div>
    <asp:Button ID="AddEventButton" runat="server" Text="Add Event" CssClass="btn btn-primary" OnClick="AddEvent_Click" />
    <asp:Label ID="ConfirmationLabel" CssClass="text-success" runat="server"></asp:Label>
</asp:Content>
