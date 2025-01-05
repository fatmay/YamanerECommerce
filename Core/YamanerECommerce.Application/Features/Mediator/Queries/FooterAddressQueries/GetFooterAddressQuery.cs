using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.Mediator.Results.FooterAddressResults;

namespace YamanerECommerce.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery :IRequest<List<GetFooterAddressQueryResult>>
    {

    }
}
