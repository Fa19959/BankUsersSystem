using UsersSystem.Data.Models;

namespace UsersSystem.Data.Repositories
{
    public interface ITransactionRepository
    {
        Task AddTransaction(Transaction transaction);
        Task DeleteTransaction(int transactionId);
        Task<IEnumerable<Transaction>> GetAllTransactions();
        Task<Transaction> GetTransactionById(int transactionId);
        Task UpdateTransaction(Transaction transaction);
    }
}