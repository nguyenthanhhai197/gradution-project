using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using eLearning.Common;
using Microsoft.AspNetCore.Http;

namespace eLearning.Web.Helper
{
    public static class FileHelper
    {
        public static async Task<string> ToUpload(this IFormFile file)
        {
            string fileExt = Path.GetExtension(file.FileName);
            string fileName = $"{Guid.NewGuid()}{fileExt}";
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", Contants.FolderUpload);
            string destPath = Path.Combine(folderPath, fileName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (var stream = File.Create(destPath))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}
