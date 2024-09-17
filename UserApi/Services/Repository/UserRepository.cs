using System.Collections.Generic;
using UserApi.Models;
using UserApi.Infraestructure.Data;
using UserApi.Services.Interface;

namespace UserApi.Services.Repository
{
    public class UserRepository : IUserRepository
    {
       private readonly BaseContext _context;
       
        public UserRepository(BaseContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
