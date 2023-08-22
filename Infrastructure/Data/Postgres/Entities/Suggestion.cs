using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Suggestion : Entity<int>
    {
        public string suggestion_header { get; set; }
        public string suggestion_detail { get; set; }
        public int category_id { get; set; }
        public int popularity { get; set; }
        public Category Category { get; set; }
        public ICollection<SuggestionsImage> SuggestionsImages { get; set; }
        public ICollection<FavoritesSuggestion> FavoritesSuggestions { get; set; }
    }
}
