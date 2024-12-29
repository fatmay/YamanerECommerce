using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Results.OrdetItem;
using YamanerECommerce.Application.Features.CQRS.Results.UserResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.UserHandlers
{
    public class GetUserQueryHandler
    {
        private readonly IRepository<User> _repository;

        public GetUserQueryHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetUserQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetUserQueryResult
            {
               Id = x.Id,
               FirstName = x.FirstName,
               LastName = x.LastName,
               Email = x.Email,
               Password = x.Password,
               PhoneNumber = x.PhoneNumber,
               Role = x.Role    
               
            }).ToList();
        }
    }
}
