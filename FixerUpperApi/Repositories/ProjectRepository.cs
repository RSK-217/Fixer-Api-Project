using FixerUpperApi.Interfaces;
using FixerUpperApi.Models;

namespace FixerUpperApi.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private static List<Project> _projectData = new()
        {
            new Project()
            {
                Id = 1,
                Title = "Interior Painting",
                Description = "Paint hallway, bathroom and spare bedroom.",
                Budget = "300",
                ProProject = false
            },
            new Project()
            {
                Id = 2,
                Title = "Repave Carport",
                Description = "Get multiple quotes.",
                Budget = "20,000",
                ProProject = true
            },
            new Project()
            {
                Id = 3,
                Title = "Cut down dead trees",
                Description = "Rent truck for hauling away debris.",
                Budget = "500",
                ProProject = false
            }
        };
        public List<Project> GetAll()
        {
            return _projectData;
        }

        public Project GetById(int id)
        {
            return _projectData.FirstOrDefault(p => p.Id == id);
        }

        public bool Create(Project value)
        {
            _projectData.Add(value);
            return true;
        }
        public void Delete(int id)
        {
            Project projectToDelete = _projectData.FirstOrDefault(p => p.Id == id);
            _projectData.Remove(projectToDelete);
        }
    }
}
