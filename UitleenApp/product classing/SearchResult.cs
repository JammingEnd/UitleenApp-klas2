using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UitleenApp.product_classing
{
    public class SearchResult<T> where T : class
    {
        public T Result { get; set; }

        public string error { get; set; }
    }
}
