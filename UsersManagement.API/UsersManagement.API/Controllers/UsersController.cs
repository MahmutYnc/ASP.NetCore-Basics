using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.API.Fake;
using UsersManagement.API.Models;

namespace UsersManagement.API.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(50);
        //public String Get() => "Heyyyyyyyyy im back sons of bitches";
        [HttpGet]
        public List<User> Get() => _users;
        [HttpGet(("{id}"))]
        public User Get(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        [HttpPost]
        public User Post([ FromBody ]User user)
        {
            _users.Add(user);
            return user;
        }


        [HttpPut]
        public User Put([FromBody] User user)
        {
            User editUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editUser.Firstname = user.Firstname;
            editUser.Lastname = user.Lastname;
            editUser.Address = user.Address;
            return user;
        }

        [HttpDelete(("{id}"))]
        public void Delete(int id)
        {
            var deletedUser =_users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deletedUser);
        }
    }
}
