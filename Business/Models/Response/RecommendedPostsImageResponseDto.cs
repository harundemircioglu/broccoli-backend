﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class RecommendedPostsImageResponseDto
    {
        public int Id { get; set; }
        public int recommended_post_id { get; set; }
        public string image_url { get; set; }
        public RecommendedPostResponseDto RecommendedPost { get; set; }
    }
}
