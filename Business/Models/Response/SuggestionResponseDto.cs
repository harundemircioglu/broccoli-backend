using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class SuggestionResponseDto
    {
        public int Id { get; set; }
        public string suggestion_header { get; set; }
        public string suggestion_detail { get; set; }
        public int category_id { get; set; }
        public int popularity { get; set; }
        public CategoryResponseDto Category { get; set; }
    }
}
