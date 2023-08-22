using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class WeightsTrackingResponseDto
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public string day { get; set; }
        public int kilo { get; set; }
        public UserProfileDto User { get; set; }
    }
}
