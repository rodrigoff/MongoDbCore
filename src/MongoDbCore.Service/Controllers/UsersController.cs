﻿using Microsoft.AspNetCore.Mvc;
using MongoDbCore.Service.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDbCore.Controllers
{
    [Route("api/[controller]")]
    public class UserViewModelsController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<UserViewModel>> Get()
        {
            throw new System.NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<UserViewModel> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public async Task Post([FromBody] UserViewModel user)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] UserViewModel user)
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
