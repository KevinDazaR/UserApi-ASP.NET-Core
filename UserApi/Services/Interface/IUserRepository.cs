using UserApi.Models;

namespace UserApi.Services.Interface
{
    public interface IUserRepository
    {
         List<User> GetAllUsers();
    }
}