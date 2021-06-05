using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eLearning.Application.FileServices.Dtos;
using eLearning.Core.Entities;

namespace eLearning.Application.FileServices
{
    public interface IFileService
    {
        Task<File> CreateFile(AddFileRequest request);
    }
}
