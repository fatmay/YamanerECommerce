using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.Mediator.Results.PricingResults;

namespace YamanerECommerce.Application.Features.Mediator.Queries.PricingQueries
{
   public class GetPricingQuery :IRequest<List<GetPricingQueryResult>>
    {

    }
}
