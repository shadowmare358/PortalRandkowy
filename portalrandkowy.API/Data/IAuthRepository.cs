using System.Threading.Tasks;
using portalrandkowy.API.Models;

namespace portalrandkowy.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Login(string username, string password);
         Task<User> Register(User user, string password);
         Task<bool> UserExists(string username);
    }
}