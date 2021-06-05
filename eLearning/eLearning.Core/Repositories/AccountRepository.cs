using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eLearning.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace eLearning.Core.Repositories
{
    public interface IAccountRepository
    {
        Task<bool> Authencation(string username, string password);
    }
    public class AccountRepository : IAccountRepository
    {
        private readonly eLearningDbcontext _context;

        public AccountRepository(eLearningDbcontext context)
        {
            this._context = context;
        }
        public async Task<bool> Authencation(string username, string password)
        {
            return await _context.Accounts.CountAsync(c => c.Username == username && c.Password == password) > 0;
        }
    }
}
