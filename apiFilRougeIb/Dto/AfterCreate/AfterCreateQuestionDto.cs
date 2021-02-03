﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiFilRougeIb.Dto.AfterCreate
{
    public class AfterCreateQuestionDto
    {
        public long? IdQuestion { get; set; }
        public string Title { get; set; }
        public long Theme_idTheme { get; set; }
        public long Level_idLevel { get; set; }
        public bool IsCreated { get; set; }


        public AfterCreateQuestionDto(string title, long theme_idTheme, long level_idLevel, bool isCreated, long? idQuestion=null)
        {
            Title = title;
            Theme_idTheme = theme_idTheme;
            Level_idLevel = level_idLevel;
            IsCreated = isCreated;
            IdQuestion = idQuestion;
        }
    }
}
