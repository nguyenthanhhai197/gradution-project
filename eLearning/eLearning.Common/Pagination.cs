using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eLearning.Common
{
    public class Pagination<TEntity> where TEntity : class
    {
        public List<TEntity> PageData { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalRows { get; set; }
        public int TotalPage { get; set; }
        public Pagination(List<TEntity> data, int totalRows, int pageIndex, int pageSize)
        {
            PageData = data;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalRows = totalRows;
            TotalPage = totalRows % pageSize == 0 ? totalRows / pageSize : (int)totalRows / pageSize + 1;
        }
    }
}
