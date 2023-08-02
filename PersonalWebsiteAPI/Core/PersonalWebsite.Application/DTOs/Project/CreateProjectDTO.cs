namespace PersonalWebsiteAPI.Application.DTOs.Project
{
    public class CreateProjectDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string ImagePath { get; set; }
    }
}
