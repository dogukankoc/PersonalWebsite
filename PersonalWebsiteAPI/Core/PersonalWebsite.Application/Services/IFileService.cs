using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace PersonalWebsiteAPI.Application.Services
{
    public interface IFileService
    {
        Task<string> FileUpload(IFormFile formFile);
    }
}
