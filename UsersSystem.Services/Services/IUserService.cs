using Microsoft.AspNetCore.Components.Forms;
using UsersSystem.Data.Models;
using static System.Net.Mime.MediaTypeNames;

namespace UsersSystem.Services.Services
{
    public interface IUserService
    {
        Task<int> AddUser(User user, IBrowserFile image);
        Task DeleteUser(int userId);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int userId);
        Task UpdateUser(User user);
    }
}