using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIListener.Models
{
    public class ListCatBreed
    {
        public int current_page_url { get; set; }
        public List<CatBreed> data { get; set; }
        public string next_page_url { get; set; }
        public string path { get; set; }
        public int per_page { get; set; }
        public string prev_page_url { get; set; }
        public int to { get; set; }
        public int total { get; set; }
        public string last_page_url { get; set; }
        public int last_page { get; set; }
        public string first_page_url { get; set; }
        public int first_page { get; set; }
        public int from { get; set; }

    }
}
