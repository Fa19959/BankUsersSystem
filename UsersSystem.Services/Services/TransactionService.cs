using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersSystem.Data.Models;
using UsersSystem.Data.Repositories;

namespace UsersSystem.Services.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactions()
        {
            return await _transactionRepository.GetAllTransactions();
        }

        public async Task<Transaction> GetTransactionById(int transactionId)
        {
            return await _transactionRepository.GetTransactionById(transactionId);
        }

        public async Task AddTransaction(Transaction transaction)
        {
            await _transactionRepository.AddTransaction(transaction);
        }

        public async Task UpdateTransaction(Transaction transaction)
        {
            await _transactionRepository.UpdateTransaction(transaction);
        }

        public async Task DeleteTransaction(int transactionId)
        {
            await _transactionRepository.DeleteTransaction(transactionId);
        }
    }
}
