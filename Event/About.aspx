<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Event.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Event Lists</h3>

<div class="table-responsive">
  <asp:GridView ID="EventsGridView" runat="server" AutoGenerateColumns="false" CssClass="table">
      <Columns>
          <asp:TemplateField HeaderText="ID">
              <ItemTemplate>
                  <%# Eval("eid") %>
              </ItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Event Name">
              <ItemTemplate>
                  <%# Eval("eventname") %>
              </ItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Event Date">
              <ItemTemplate>
                  <%# Eval("eventdate") %>
              </ItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Action">
              <ItemTemplate>
                <asp:Button ID="EditButton" runat="server" Text="Edit" OnClick="Edit_Click" CommandArgument='<%# Eval("eid") %>' CssClass="btn btn-primary"/>           
                  <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="Delete_Click" CommandArgument='<%# Eval("eid") %>' CssClass="btn btn-danger"/>
              </ItemTemplate>
          </asp:TemplateField>
      </Columns>
  </asp:GridView>
</div>


</asp:Content>
