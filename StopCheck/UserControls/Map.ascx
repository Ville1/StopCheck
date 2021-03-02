<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Map.ascx.cs" Inherits="StopCheck.UserControls.Map" %>

<style>
    .map {
        height: <%= Size %>px;
        width: <%= Size %>px;
    }
</style>

<div id="OLMap" runat="server" class="map"></div>
<script type="text/javascript">
    $(document).ready(function () {
        var map = new ol.Map({
            target: '<%= OLMap.ClientID %>',
            layers: [
              new ol.layer.Tile({
                  source: new ol.source.OSM()
              })
            ],
            view: new ol.View({
                center: ol.proj.fromLonLat([
                    <%= Longitude %>,
                    <%= Latitude %>
                ]),
                zoom: <%= Zoom %>
            })
        });
    });
</script>