using Microsoft.AspNetCore.Http;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;

namespace PersonalWebsiteAPI.Persistence.Services
{
    public class FileService : IFileService
    {
        
        public FileService() { }
        public  async Task<string> FileUpload(IFormFile formFile)
        {
            if (formFile != null)
            {
                var extent = Path.GetExtension(formFile.FileName);
                var randomName = ($"{Guid.NewGuid()}{extent}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
                return path;
            }
            else
            {
                return null;
            }
        }
    }
}
