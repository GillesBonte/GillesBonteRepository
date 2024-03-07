using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIListener.Models
{
    public class APIList
    {
        public int count {  get; set; }
        public List<APIModel> entries { get; set; }
    }
}
