using UsersSystem.Data.Models;

namespace UsersSystem.Data.Repositories
{
    public interface IUserRepository
    {
        Task<int> AddUser(User user);
        Task DeleteUser(int userId);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int userId);
        Task UpdateUser(User user);
    }
}