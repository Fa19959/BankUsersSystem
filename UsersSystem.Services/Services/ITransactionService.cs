using UsersSystem.Data.Models;

namespace UsersSystem.Services.Services
{
    public interface ITransactionService
    {
        Task AddTransaction(Transaction transaction);
        Task DeleteTransaction(int transactionId);
        Task<IEnumerable<Transaction>> GetAllTransactions();
        Task<Transaction> GetTransactionById(int transactionId);
        Task UpdateTransaction(Transaction transaction);
    }
}