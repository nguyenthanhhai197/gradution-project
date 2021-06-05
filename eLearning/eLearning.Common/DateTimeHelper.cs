using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Common
{
    public static class DateTimeHelper
    {
        public static string ToFormat(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }
    }
}
