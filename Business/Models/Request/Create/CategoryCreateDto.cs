﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CategoryCreateDto
    {
        public string category_name { get; set; }
        public int popularity { get; set; }
    }
}
