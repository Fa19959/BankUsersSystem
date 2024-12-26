using UsersSystem.Data.Models;

namespace UsersSystem.Services.Services
{
    public interface IAccountService
    {
        Task AddAccount(Account account);
        Task DeleteAccount(int accountNumber);
        Task<Account> GetAccountById(int accountNumber);
        Task<IEnumerable<Account>> GetAllAccounts();
        Task UpdateAccount(Account account);
    }
}