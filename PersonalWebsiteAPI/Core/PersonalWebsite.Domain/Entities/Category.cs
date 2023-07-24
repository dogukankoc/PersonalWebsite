using PersonalWebsiteAPI.Domain.Entities.Common;

namespace PersonalWebsiteAPI.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
