using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmdbAPI
{
    class SearchResultData
    {
        public List<MovieData> Search { get; set; }

        public string Response { get; set; }
    }
}
