﻿using Explorer.Tours.API.Dtos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.API.Public
{
    public interface IAnswerDatesService
    {
        Result<AnswerDateDto> GetAnswerDateByUserId(int userId);
        Result<AnswerDateDto> UpdateAnswerDate(int userId);
    }
}
