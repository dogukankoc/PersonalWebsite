using PersonalWebsiteAPI.Application.DTOs.Project;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Application.Services
{
    public interface IProjectService
    {
        IQueryable<Project> GetProjects();
        Task<Project> GetProjectByIdAsync(int id);
        Task<int> CreateProjectAsync(CreateProjectDTO createProjectDTO);
        Task<Project> UpdateProjectByIdAsync(int id, UpdateProjectDTO updateProjectDTO);
        Task<bool> DeleteProjectAsyncById(int id);
        public  Task<Project> SoftDeleteByIdAsync(int id);
    }
}
