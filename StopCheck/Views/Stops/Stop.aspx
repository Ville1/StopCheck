<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Stop.aspx.cs" Inherits="StopCheck.Views.Stops.Stop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><asp:Literal ID="NameLiteral" runat="server" /></h1>

    <div class="row">
        <div class="col-12 col-sm-6 col-md-4 col-lg-4 col-xl-4">
            <table class="table">
                <thead class="thead-light">
                    <tr>
                        <th scope="col">
                            Headsign
                        </th>
                        <th scope="col">
                            Arrives
                        </th>
                        <th scope="col">
                            Departs
                        </th>
                    </tr>
                </thead>
                <tbody id="table-body">
                </tbody>
            </table>
        </div>
    </div>
    <span id="refresh-button" class="btn btn-primary">Refresh</span>

    <script type="text/javascript">
        $(document).ready(function () {

            var refresh = function () {
                $.ajax({
                    url: '<%= StopCheck.Utils.UrlHelper.ParseAjaxUrl(Request) %>',
                    data: '{ "id": "<%= Id %>" }',
                    contentType: 'application/json; charset=utf-8',
                    type: 'post',
                    dataType: 'json',
                    success: function (data) {
                        var tableBody = $('#table-body');
                        $('.departure-row').remove();
                        data.d.Departures.forEach(function (item, index) {
                            tableBody.append(
                                '<tr class="departure-row">' +
                                    '<td>' +
                                        item.Headsign +
                                    '</td>' +
                                    '<td>' +
                                        item.Arrival.Realtime +
                                    '</td>' +
                                    '<td>' +
                                        item.Departure.Realtime +
                                    '</td>' +
                                '</tr>'
                            );
                        });
                    },
                    error: function (error) {
                        console.log(error.responseText);
                    }
                });
            }
            refresh();
            $('#refresh-button').on('click', refresh);
        });
    </script>
</asp:Content>
