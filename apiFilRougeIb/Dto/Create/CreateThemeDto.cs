﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiFilRougeIb.Dto.Create
{
    public class CreateThemeDto
    {
        public string Category { get; set; }
        public CreateThemeDto(string category)
        {
            this.Category = category;
        }


    }
}
