using PersonalWebsiteAPI.Domain.Entities.Common;

namespace PersonalWebsiteAPI.Domain.Entities
{
    public class Project : BaseEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string ImagePath { get; set; }
        public User User { get; set; }
    }
}
