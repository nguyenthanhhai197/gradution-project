using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.LessionServices.Dtos;
using eLearning.Common;
using eLearning.Core.Data;
using eLearning.Core.Entities;
using eLearning.Core.Repositories;

namespace eLearning.Application.LessionServices
{
    public class LessionService : ILessionService
    {
        private readonly IRepository<Lession> _repository;
        private readonly ILessionRepository _lessionRepository;

        public LessionService(IRepository<Lession> repository, ILessionRepository lessionRepository)
        {
            this._repository = repository;
            this._lessionRepository = lessionRepository;
        }
        public async Task<Lession> AddLession(AddLessionRequest request)
        {
            return await _repository.AddAsync(request.ToEntity());
        }

        public async Task DeleteLession(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<List<Lession>> GetLessionByCourseId(Guid id)
        {
            return await _lessionRepository.GetAllByCourseId(id);
        }

        public async Task UpdateLession(UpdateLessionRequest request)
        {
            await _repository.UpdateAsync(request.ToEntity());
        }
    }
}
