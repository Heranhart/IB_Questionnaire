﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiFilRougeIb.Dto.Update
{
    public class UpdateSolutionDto
    {
        public string Solution { get; set; }
        public long Question_idquestion { get; set; }
        public UpdateSolutionDto(string solution,long question_idquestion)
        {
            this.Solution = solution;
            this.Question_idquestion =question_idquestion;
        }


    }
}
