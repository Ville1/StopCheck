using StopCheck.Data.API;
using StopCheck.Data.API.HSL;
using System.Web.UI;

namespace StopCheck.Views
{
    public class BasePage : Page
    {
        private IAPI api;

        public IAPI Api
        {
            get {
                if(api != null) {
                    return api;
                }
                api = new HSLAPI();
                return api;
            }
        }
    }
}