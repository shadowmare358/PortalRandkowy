using System.Threading.Tasks;
using System.Collections.Generic;
using portalrandkowy.API.Models;

namespace portalrandkowy.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Login(string username, string password);
         Task<User> Register(User user, string password);
         Task<bool> UserExists(string username);
         Task<List<User>> GetUsers();
    }
}