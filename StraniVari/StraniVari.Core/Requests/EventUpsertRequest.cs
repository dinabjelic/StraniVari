﻿namespace StraniVari.Core.Requests
{
    public class EventUpsertRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StraniVariTheme { get; set; }
    }
}
