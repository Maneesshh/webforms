<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEvent.aspx.cs" Inherits="Event.EditEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Edit Event</h2>
        <div class="form-group">
            <asp:Label ID="EventNameLabel" runat="server" Text="Event Name:" CssClass="control-label" AssociatedControlID="EventName"></asp:Label>
            <asp:TextBox ID="EventName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="EventDateLabel" runat="server" Text="Event Date:" CssClass="control-label" AssociatedControlID="EventDate"></asp:Label>
            <asp:TextBox ID="EventDate" runat="server" CssClass="form-control" TextMode="DateTimeLocal"></asp:TextBox>
        </div>
        <asp:Button ID="SaveButton" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="Save_Click" />
        <asp:Label ID="ConfirmationLabel" runat="server" CssClass="text-success"></asp:Label>
</asp:Content>
