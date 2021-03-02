using System.Web;

namespace StopCheck.Utils
{
    public class UrlHelper
    {
        public static readonly string ERROR_PAGE = "~/Views/Error.aspx";

        public static string ParseAjaxUrl(HttpRequest request)
        {
            return string.Format("{0}://{1}/{2}", request.Url.Scheme, request.Url.Authority, "Ajax/StopDepartures.asmx/GetDepartures");
        }
    }
}