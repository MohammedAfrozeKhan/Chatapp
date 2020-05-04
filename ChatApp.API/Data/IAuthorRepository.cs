using System.Threading.Tasks;
using ChatApp.API.Models;

namespace ChatApp.API.Data
{
    public interface IAuthorRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);

         Task<bool> UserExists(string username);
    }
}