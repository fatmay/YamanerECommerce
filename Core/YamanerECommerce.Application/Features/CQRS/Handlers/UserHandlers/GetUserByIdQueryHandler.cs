using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderItemQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.UserQueries;
using YamanerECommerce.Application.Features.CQRS.Results.OrdetItem;
using YamanerECommerce.Application.Features.CQRS.Results.UserResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.UserHandlers
{
    public class GetUserByIdQueryHandler
    {
        private readonly IRepository<User> _repository;

        public GetUserByIdQueryHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
    
    public async Task<GetUserByIdQueryResult> Handle(GetUserByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetUserByIdQueryResult
            {
                Role = values.Role,
                PhoneNumber = values.PhoneNumber,
                Password = values.Password,
                Email = values.Email,
                FirstName = values.FirstName,
                LastName = values.LastName,
                Id = values.Id


            };
        }
    } }
