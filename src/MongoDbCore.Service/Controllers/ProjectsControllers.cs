using Microsoft.AspNetCore.Mvc;
using MongoDbCore.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDbCore.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsControllers : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<Project>> Get()
        {
            throw new System.NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<Project> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public async Task Post([FromBody] Project project)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Project project)
        {
            throw new System.NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
