using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class SuggestionsImageResponseDto
    {
        public int Id { get; set; }
        public int suggestion_id { get; set; }
        public string image_url { get; }
        public SuggestionResponseDto Suggestion { get; set; }
    }
}
