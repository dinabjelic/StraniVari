﻿namespace StraniVari.Core.Responses
{
    public class GetTripsDetailsForEventResponse
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public DateTime TripDateTime { get; set; }
        public string Status { get; set; }
        public int TripId { get; set; }
    }
}
