using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteAPI.Application.Services;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;
        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpGet]
        public IActionResult ImageUpload()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult ImageUpload(IFormFile formFile)
        {
            return Ok();
        }
    }
}
