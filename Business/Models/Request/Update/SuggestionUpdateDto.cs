using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class SuggestionUpdateDto
    {
        public string suggestion_header { get; set; }
        public string suggestion_detail { get; set; }
        public int category_id { get; set; }
        public int popularity { get; set; }
    }
}
