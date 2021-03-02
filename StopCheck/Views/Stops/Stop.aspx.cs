using StopCheck.Utils;
using System;

namespace StopCheck.Views.Stops
{
    //http://localhost:54569/Views/Stops/Stop?id=1140447
    public partial class Stop : BasePage
    {
        protected string Id
        {
            get {
                return Request.Params["id"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) {
                return;
            }
            if(string.IsNullOrEmpty(Id)) {
                Response.Redirect(UrlHelper.ERROR_PAGE);
                return;
            }

            Data.Stop stop = Api.GetStop(Id);
            if(stop == null) {
                Response.Redirect(UrlHelper.ERROR_PAGE);
                return;
            }
            NameLiteral.Text = stop.Name;
        }
    }
}