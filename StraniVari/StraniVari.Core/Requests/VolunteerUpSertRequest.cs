﻿namespace StraniVari.Core.Requests
{
    public class VolunteerUpSertRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartDateOfVolunteering { get; set; }
    }
}
