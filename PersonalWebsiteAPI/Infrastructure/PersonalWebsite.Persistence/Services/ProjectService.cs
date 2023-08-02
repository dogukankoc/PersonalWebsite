using Mapster;
using PersonalWebsiteAPI.Application.DTOs.Project;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;
using PersonalWebsiteAPI.Domain.Entities;

namespace PersonalWebsiteAPI.Persistence.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectWriteRepository _projectWriteRepository;
        private readonly IProjectReadRepository _projectReadRepository;
        public ProjectService(IProjectWriteRepository projectWriteRepository, IProjectReadRepository projectReadRepository)
        {
            _projectWriteRepository = projectWriteRepository;
            _projectReadRepository = projectReadRepository;
        }

        public IQueryable<Project> GetProjects()
        {
            return _projectReadRepository.GetAll();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await _projectReadRepository.GetByIdAsync(id);
        }
        public List<Project> LastProjectsByNumber(int number)
        {
            return _projectReadRepository.Table.OrderByDescending(data => data.CreatedDate).Take(number).ToList();
        }

        public async Task<int> CreateProjectAsync(CreateProjectDTO createProjectDTO)
        {
            Project project = createProjectDTO.Adapt<Project>();
            return await _projectWriteRepository.AddAsync(project);
        }

        public async Task<Project> UpdateProjectByIdAsync(int id, UpdateProjectDTO updateProjectDTO)
        {
            return await _projectWriteRepository.UpdateAsync(updateProjectDTO.Adapt(await GetProjectByIdAsync(id)));
        }

        public async Task<bool> DeleteProjectAsyncById(int id)
        {
           return await _projectWriteRepository.RemoveAsyncById(id);
        }

        public async Task<Project> SoftDeleteByIdAsync(int id)
        {
            Project project = await GetProjectByIdAsync(id);
            project.IsDeleted = true;
            return await _projectWriteRepository.UpdateAsync(project);
        }

    }
}
