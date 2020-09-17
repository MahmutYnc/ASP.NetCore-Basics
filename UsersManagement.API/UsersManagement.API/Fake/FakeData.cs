using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using UsersManagement.API.Models;

namespace UsersManagement.API.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int quantity)
        {
            if(_users == null)
            {

            _users = new Faker<User>()
             .RuleFor(u => u.Id, f => f.IndexFaker)
             .RuleFor(u => u.Firstname, f => f.Name.FirstName())
             .RuleFor(u => u.Lastname, f => f.Name.LastName())
             .RuleFor(u => u.Address, f => f.Address.FullAddress())
             .Generate(quantity);

            }

        return _users;
        }
    }
}
