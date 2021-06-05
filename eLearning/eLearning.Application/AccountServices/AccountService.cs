using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.AccountServices.Dtos;
using eLearning.Core.Repositories;

namespace eLearning.Application.AccountServices
{
    public interface IAccountService
    {
        Task<bool> Login(LoginRequest request);
    }
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            this._repository = repository;
        }
        public async Task<bool> Login(LoginRequest request)
        {
            return await _repository.Authencation(request.Username, request.Password);
        }
    }
}
