using StopCheck.UserControls;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace StopCheck.Views.Stops
{
    public partial class StopSearch : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text)) {
                return;
            }
            List<Data.Stop> results = Api.Search(SearchTextBox.Text);

            if (results == null) {
                //Error?
                return;
            }
            SearchResultsRepeater.DataSource = results;

            DataBind();
        }

        protected void SearchResultsRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Data.Stop stop = e.Item.DataItem as Data.Stop;
            HyperLink link = e.Item.FindControl("StopHyperLink") as HyperLink;
            link.Text = stop.Name;
            link.NavigateUrl = "~/Views/Stops/Stop?id=" + stop.Id;
        }
    }
}