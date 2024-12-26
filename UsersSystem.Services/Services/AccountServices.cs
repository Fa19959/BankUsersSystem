using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersSystem.Data.Models;
using UsersSystem.Data.Repositories;

namespace UsersSystem.Services.Services
{
    public class AccountServices : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountServices(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IEnumerable<Account>> GetAllAccounts()
        {
            return await _accountRepository.GetAllAccounts();
        }

        public async Task<Account> GetAccountById(int accountNumber)
        {
            return await _accountRepository.GetAccountById(accountNumber);
        }

        public async Task AddAccount(Account account)
        {
            await _accountRepository.AddAccount(account);
        }

        public async Task UpdateAccount(Account account)
        {
            await _accountRepository.UpdateAccount(account);
        }

        public async Task DeleteAccount(int accountNumber)
        {
            await _accountRepository.DeleteAccount(accountNumber);
        }

        //private async Task AddFiles(InputFileChangeEventArgs e)
        //{
        //    foreach (var file in e.GetMultipleFiles())
        //    {
        //        // Ensure the file is a JPG file
        //        if (file.ContentType == "image/jpg")
        //        {
        //            var path = Path.Combine("D:\\Blazor Course\\Codeline\\Day 9\\Photos", file.Name);

        //            // Save the file to the server
        //            using var stream = file.OpenReadStream();
        //            using var fileStream = new FileStream(path, FileMode.Create);
        //            await stream.CopyToAsync(fileStream);

        //            statusMessage = "Files uploaded successfully.";
        //        }
        //        else
        //        {
        //            statusMessage = "Only JPG files are allowed.";
        //        }
        //    }
        //}
    }
}
