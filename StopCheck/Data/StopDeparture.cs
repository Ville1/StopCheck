using System;

namespace StopCheck.Data
{
    public class StopDeparture
    {
        public string Headsign { get; set; }
        public StopDepartureTime Arrival { get; set; }
        public StopDepartureTime Departure { get; set; }

        public class StopDepartureTime
        {
            public DateTime Realtime { get; set; }
            public DateTime Scheduled { get; set; }
            public int Delay { get; set; }
        }
    }
}