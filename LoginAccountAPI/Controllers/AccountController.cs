using LoginAccountAPI.Data;
using LoginAccountAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginAccountAPI.Controllers
{
   

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly LoginAccountDbContext dbContext;

        public AccountController(LoginAccountDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        [Route("/getUsers")]
        public async Task<IActionResult> GetAccount()
        {
            return Ok(await dbContext.accountInfos.ToListAsync());
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetAccount([FromRoute] int id)
        {
            var accountInfo = dbContext.accountInfos.Find(id);
            if (accountInfo == null)
            {
                return NotFound();
            }
            return Ok(accountInfo);
        }
        [HttpPost]
        public async Task<IActionResult> AddAccount(AddAccountRequest addAccountRequest)
        {
            var account = new LoginAcount()
            {
                Id= Guid.NewGuid(),
                UserName = addAccountRequest.UserName,
                Password = addAccountRequest.Password,
                Score = addAccountRequest.Score,
            };

            await dbContext.accountInfos.AddAsync(account);
            await dbContext.SaveChangesAsync();
            return Ok(account);
        }
        [HttpPost]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateAccount([FromRoute] int id, UpdateAccountRequest updateAccountRequest)
        {
            var accountInfo = await dbContext.accountInfos.FindAsync(id);
            if (accountInfo != null)
            {
                accountInfo.UserName = updateAccountRequest.UserName;
                accountInfo.Password = updateAccountRequest.Password;
                accountInfo.Score = updateAccountRequest.Score; 
                await dbContext.SaveChangesAsync();
                return Ok(accountInfo);
            }
            return NotFound();
        }
    }
}
