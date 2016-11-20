using Microsoft.AspNetCore.Mvc;
using MongoDbCore.Service.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDbCore.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<ProjectViewModel>> Get()
        {
            throw new System.NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<ProjectViewModel> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public async Task Post([FromBody] ProjectViewModel project)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ProjectViewModel project)
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
