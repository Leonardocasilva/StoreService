using Microsoft.AspNetCore.Mvc;
using StoreService.Models;
using StoreService.Repository;
using System.Collections.Generic;

namespace StoreService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _UsersRepo;

        public UsersController(IUser UsersRepo)
        {
            _UsersRepo = UsersRepo;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _UsersRepo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}", Name="GetUser")]
        public User Find(long id)
        {
            return _UsersRepo.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _UsersRepo.Add(user);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody] User user)
        {
            _UsersRepo.update(user);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _UsersRepo.remove(id);
        }
    }
}
