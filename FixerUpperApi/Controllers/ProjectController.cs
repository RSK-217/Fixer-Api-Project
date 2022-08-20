using Microsoft.AspNetCore.Mvc;
using FixerUpperApi.Repositories;
using FixerUpperApi.Models;
using FixerUpperApi.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FixerUpperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepo = projectRepository;
        }

        private IProjectRepository _projectRepo;

        // GET: api/<ProjectController>
        [HttpGet]
        public List<Project> GetAll()
        {
            return _projectRepo.GetAll();
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public Project GetById(int id)
        {
            return _projectRepo.GetById(id);
        }

        // POST api/<ProjectController>
        [HttpPost]
        public IActionResult Post([FromBody] Project value)
        {
            if (_projectRepo.Create(value))
            {
                return Created("",value);
            };
            return NotFound();
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _projectRepo.Delete(id);
        }
    }
}
