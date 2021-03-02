using StopCheck.Data;
using StopCheck.Utils;
using StopCheck.Views;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;

namespace StopCheck.Ajax
{
    [WebService(Namespace = "StopCheck")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    public class StopDepartures : WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public AjaxDepartures GetDepartures(string id)
        {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            BasePage basePage = new BasePage();
            Stop stop = basePage.Api.GetStop(id);
            if(stop == null) {
                return null;
            }
            return new AjaxDepartures() {
                Departures = stop.Departures.Select(x => new AjaxDeparture() {
                    Headsign = x.Headsign,
                    Arrival = new AjaxDepartureTime() {
                        Realtime = x.Arrival.Realtime.ToString(Config.TimeFormat),
                        Scheduled = x.Arrival.Scheduled.ToString(Config.TimeFormat),
                        Delay = x.Arrival.Delay
                    },
                    Departure = new AjaxDepartureTime() {
                        Realtime = x.Departure.Realtime.ToString(Config.TimeFormat),
                        Scheduled = x.Departure.Scheduled.ToString(Config.TimeFormat),
                        Delay = x.Departure.Delay
                    }
                }).ToList()
            };
        }
    }

    public class AjaxDepartures
    {
        public List<AjaxDeparture> Departures { get; set; }
    }

    public class AjaxDeparture
    {
        public string Headsign { get; set; }
        public AjaxDepartureTime Arrival { get; set; }
        public AjaxDepartureTime Departure { get; set; }
    }

    public class AjaxDepartureTime
    {
        public string Realtime { get; set; }
        public string Scheduled { get; set; }
        public int Delay { get; set; }
    }
}
