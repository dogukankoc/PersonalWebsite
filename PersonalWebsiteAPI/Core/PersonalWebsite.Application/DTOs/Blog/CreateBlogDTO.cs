namespace PersonalWebsiteAPI.Application.DTOs.Blog
{
    public class CreateBlogDTO
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
