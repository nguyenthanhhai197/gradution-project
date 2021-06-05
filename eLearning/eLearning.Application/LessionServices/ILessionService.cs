using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.LessionServices.Dtos;
using eLearning.Common;
using eLearning.Core.Entities;

namespace eLearning.Application.LessionServices
{
    public interface ILessionService
    {
        Task<Lession> AddLession(AddLessionRequest request);
        Task UpdateLession(UpdateLessionRequest request);
        Task DeleteLession(Guid id);
        Task<List<Lession>> GetLessionByCourseId(Guid id);
    }
}
