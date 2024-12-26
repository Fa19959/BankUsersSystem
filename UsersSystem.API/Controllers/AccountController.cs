using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersSystem.Data.Models;
using UsersSystem.API.DTOs;
using UsersSystem.Services.Services;

namespace UsersSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAllAccounts()
        {
            return Ok(await _accountService.GetAllAccounts());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccountById(int id)
        {
            var account = await _accountService.GetAccountById(id);
            if (account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        [HttpPost]
        public async Task<ActionResult> AddAccount(AccountDto accountDto)
        {
            var account = new Account { AccountNumber= accountDto.AccountNumber,
                                        AccountType = accountDto.AccountType,
                                        Balance = accountDto.Balance,
                                        UserID = accountDto.UserID};

            await _accountService.AddAccount(account);
            return CreatedAtAction(nameof(GetAccountById), new { id = account.AccountNumber }, account);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAccount(int id, Account account)
        {
            if (id != account.AccountNumber)
            {
                return BadRequest();
            }
            await _accountService.UpdateAccount(account);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            await _accountService.DeleteAccount(id);
            return NoContent();
        }
    }
}
