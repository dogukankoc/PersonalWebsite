using PersonalWebsiteAPI.Domain.Entities.Common;

namespace PersonalWebsiteAPI.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
