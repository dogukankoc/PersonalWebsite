using Microsoft.AspNetCore.Mvc;
using PersonalWebsiteAPI.Application.DTOs.Project;
using PersonalWebsiteAPI.Application.Services;

namespace PersonalWebsiteAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult GetProjects()
        {
            return Ok(_projectService.GetProjects());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectById(int id)
        {
            return Ok(await _projectService.GetProjectByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDTO createProjectDTO)
        {
            return Ok(await _projectService.CreateProjectAsync(createProjectDTO));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, UpdateProjectDTO updateProjectDTO)
        {
            return Ok(await _projectService.UpdateProjectByIdAsync(id,updateProjectDTO));
        }

        [HttpDelete("{id}")]
        public async  Task<IActionResult> DeleteProject(int id)
        {
            return Ok(await _projectService.DeleteProjectAsyncById(id));
        }

        [HttpDelete]
        [Route("softdelete/{id}")]
        public async Task<IActionResult> SoftDeleteProject (int id) 
        {
            return Ok(await _projectService.SoftDeleteByIdAsync(id));
        }
    }
}
