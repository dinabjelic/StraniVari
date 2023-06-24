namespace StraniVari.Core.Entities
{
    public class Administrator: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }

        public User User { get; set; }
    }
}
