﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.Mediator.Queries.LocationQueries;
using YamanerECommerce.Application.Features.Mediator.Results.LocationResults;
using YamanerECommerce.Application.Interfaces;
using YamanerECommerce.Domain.Entities;

namespace YamanerECommerce.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult
            {
                Name = x.Name,
                LocationID = x.LocationID,
            }).ToList();


        }    
    }
}
