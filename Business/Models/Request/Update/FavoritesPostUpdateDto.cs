using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class FavoritesPostUpdateDto
    {
        public int user_id { get; set; }
        public int post_id { get; set; }
    }
}
