﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class RecommendedPostsImageUpdateDto
    {
        public int recommended_post_id { get; set; }
        public string image_url { get; set; }
    }
}
