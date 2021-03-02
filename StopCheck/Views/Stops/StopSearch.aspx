<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StopSearch.aspx.cs" Inherits="StopCheck.Views.Stops.StopSearch" %>
<%@ Register Src="~/UserControls/Map.ascx" TagName="Map" TagPrefix="Custom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <asp:TextBox ID="SearchTextBox" runat="server" CssClass="form-control" />
    <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" CssClass="btn btn-primary" />

    <div class="row">
        <div class="col-12 col-sm-12 col-md-6 col-lg-6 col-xl-6">
            <table class="table">
                <thead class="thead-light">
                    <tr>
                        <th scope="col" style="width: 20%;">
                            Stop
                        </th>
                        <th scope="col">
                            Map
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="SearchResultsRepeater" runat="server" ItemType="StopCheck.Data.Stop" OnItemDataBound="SearchResultsRepeater_ItemDataBound">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:HyperLink ID="StopHyperLink" runat="server" />
                                </td>
                                <td>
                                    <Custom:Map ID="Map" runat="server" Size="200" Zoom="18" Latitude="<%# Item.Latitude %>" Longitude="<%# Item.Longitude %>" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
