using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;
        private readonly IProjectService _projectService;
        public FilesController(IFileService fileService, IProjectService projectService)
        {
            _fileService = fileService;
            _projectService = projectService;
        }

        [HttpPost]
        public async Task<IActionResult> FileUpload(IFormFile formFile)
        {
            
            return Ok(await _fileService.FileUpload(formFile));
        }
    }
}
