using System.Threading.Tasks;
using CodehelpApp.API.Models;

namespace CodehelpApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register (User user, string password);
         Task<User> Login (string email, string password);
         Task<bool> UserExists (string email);
    }
}