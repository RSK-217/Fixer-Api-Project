using FixerUpperApi.Models;

namespace FixerUpperApi.Interfaces
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
        Project GetById(int id);    
        bool Create(Project project);
        void Delete(int Id);

    }
}
