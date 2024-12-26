using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersSystem.Data.Models;

namespace UsersSystem.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {

        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
             return await _context.Accounts.ToListAsync();
        }

        public async Task<Account> GetAccountById(int accountNumber)
        {
            //return await _context.Accounts.FindAsync(accountNumber);
            return await _context.Accounts.Include(a => a.User)
                                          .FirstOrDefaultAsync(a => a.AccountNumber == accountNumber);
        }

        public async Task AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAccount(Account account)
        {
            _context.Entry(account).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAccount(int accountNumber)
        {
            var account = await _context.Accounts.FindAsync(accountNumber);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                await _context.SaveChangesAsync();
            }
        }

    }
}
