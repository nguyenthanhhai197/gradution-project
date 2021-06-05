using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.FileServices.Dtos;
using eLearning.Core.Data;
using eLearning.Core.Entities;

namespace eLearning.Application.FileServices
{
    public class FileServicecs : IFileService
    {
        private readonly IRepository<File> _repository;

        public FileServicecs(IRepository<File> repository)
        {
            this._repository = repository;
        }
        public async Task<File> CreateFile(AddFileRequest request)
        {
            var entity = request.ToEntity();
            return await _repository.AddAsync(entity);
        }
    }
}
