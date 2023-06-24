namespace StraniVari.Core.Responses
{
    public class GetAdministratorDetailsResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
