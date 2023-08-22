using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class SuggestionsImage : Entity<int>
    {
        public int suggestion_id { get; set; }
        public string image_url { get; set; }
        public Suggestion Suggestion { get; set; }
    }
}
