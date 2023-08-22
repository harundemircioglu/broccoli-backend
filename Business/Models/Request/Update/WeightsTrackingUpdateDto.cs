using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class WeightsTrackingUpdateDto
    {
        public int user_id { get; set; }
        public string day { get; set; }
        public int kilo { get; set; }
    }
}
