using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class FavoritesPostResponseDto
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public int post_id { get; set; }
        public UserProfileDto User { get; set; }
        public PostResponseDto Post { get; set; }
    }
}
