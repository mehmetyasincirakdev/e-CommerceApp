using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        internal static readonly string ProductAdded;

        public static string ProductCountOfCategoryError { get; internal set; }
        public static string ProductNameAlreadyExists { get; internal set; }
        public static string CategoryLimitExceded { get; internal set; }
    }
}
