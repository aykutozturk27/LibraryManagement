using LibraryManagement.Core.Entities;

namespace LibraryManagement.Entities.Concrete
{
    public class Personal : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IdentityNumber { get; set; }
        public string? PhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public List<Book>? Books { get; set; }
    }
}
