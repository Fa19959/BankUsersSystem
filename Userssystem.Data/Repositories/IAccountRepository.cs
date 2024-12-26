using UsersSystem.Data.Models;

namespace UsersSystem.Data.Repositories
{
    public interface IAccountRepository
    {
        Task AddAccount(Account account);
        Task DeleteAccount(int accountNumber);
        Task<Account> GetAccountById(int accountNumber);
        Task<IEnumerable<Account>> GetAllAccounts();
        Task UpdateAccount(Account account);
    }
}