﻿using Explorer.Tours.API.Dtos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.API.Public.Author
{
    public interface ITourSaleConnectionService
    {
        Result<TourSaleConnectionDto> CreateWithRestrictions(TourSaleConnectionDto tourSaleConnection);
    }
}
